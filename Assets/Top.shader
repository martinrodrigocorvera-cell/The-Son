Shader "Custom/Top"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _Color ("Color Tint", Color) = (1,1,1,1)

        [Toggle(_EMISSION_ON)] _UseEmission ("Enable Glow", Float) = 0
        [HDR]_EmissionColor ("Emission Color", Color) = (0,0,0,0)
        _EmissionMap ("Emission Map", 2D) = "black" {}
    }

    SubShader
    {
        Tags { "RenderType"="Opaque" "Queue"="Overlay" }

        Pass
        {
            Name "ForwardBase"
            Tags { "LightMode"="ForwardBase" }

            Stencil
            {
                Ref 1
                Comp Always
                Pass Replace
            }

            ZWrite Off
            ZTest Always
            Offset -1, -1

            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma multi_compile_fwdbase
            #pragma shader_feature _EMISSION_ON
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "AutoLight.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float4 pos : SV_POSITION;
                float2 uv : TEXCOORD0;
                float3 worldNormal : TEXCOORD1;
                float3 worldPos : TEXCOORD2;
                SHADOW_COORDS(3)
            };

            sampler2D _MainTex;
            sampler2D _EmissionMap;

            fixed4 _Color;
            fixed4 _EmissionColor;

            v2f vert(appdata v)
            {
                v2f o;
                o.pos = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;

                o.worldNormal = UnityObjectToWorldNormal(v.normal);
                o.worldPos = mul(unity_ObjectToWorld, v.vertex).xyz;

                TRANSFER_SHADOW(o);
                return o;
            }

            fixed4 frag(v2f i) : SV_Target
            {
                fixed3 normal = normalize(i.worldNormal);
                fixed3 albedo = tex2D(_MainTex, i.uv).rgb * _Color.rgb;

                fixed3 lightDir = normalize(_WorldSpaceLightPos0.xyz);
                fixed NdotL = max(0, dot(normal, lightDir));
                fixed shadow = SHADOW_ATTENUATION(i);

                fixed3 ambient = UNITY_LIGHTMODEL_AMBIENT.rgb * albedo;
                fixed3 diffuse = _LightColor0.rgb * albedo * NdotL * shadow;

                fixed3 finalColor = ambient + diffuse;

                #ifdef _EMISSION_ON
                    fixed3 emissionTex = tex2D(_EmissionMap, i.uv).rgb;
                    fixed3 emission = emissionTex * _EmissionColor.rgb;
                    finalColor += emission;
                #endif

                return fixed4(finalColor, 1);
            }
            ENDCG
        }
        Pass
        {
            Name "ForwardAdd"
            Tags { "LightMode"="ForwardAdd" }
            Blend One One
            ZWrite Off
            ZTest Always

            CGPROGRAM
            #pragma vertex vert
            #pragma fragment fragAdd
            #pragma multi_compile_fwdadd_fullshadows
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "AutoLight.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float4 pos : SV_POSITION;
                float2 uv : TEXCOORD0;
                float3 worldNormal : TEXCOORD1;
                float3 worldPos : TEXCOORD2;
                LIGHTING_COORDS(3,4)
            };

            sampler2D _MainTex;
            fixed4 _Color;

            v2f vert(appdata v)
            {
                v2f o;
                o.pos = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;

                o.worldNormal = UnityObjectToWorldNormal(v.normal);
                o.worldPos = mul(unity_ObjectToWorld, v.vertex).xyz;

                TRANSFER_VERTEX_TO_FRAGMENT(o);
                return o;
            }

            fixed4 fragAdd(v2f i) : SV_Target
            {
                fixed3 normal = normalize(i.worldNormal);
                fixed3 lightDir = normalize(_WorldSpaceLightPos0.xyz);

                fixed NdotL = max(0, dot(normal, lightDir));
                fixed atten = LIGHT_ATTENUATION(i);

                fixed3 albedo = tex2D(_MainTex, i.uv).rgb * _Color.rgb;

                fixed3 diffuse = _LightColor0.rgb * albedo * NdotL * atten;

                return fixed4(diffuse, 0);
            }
            ENDCG
        }
    }
}