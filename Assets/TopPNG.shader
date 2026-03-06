Shader "Custom/TopPNG"
{
    Properties
    {
        _MainTex ("Textura (PNG)", 2D) = "white" {}
        _Color   ("Color tint",   Color) = (1,1,1,1)
        _Cutoff  ("Alpha Cutoff", Range(0,1)) = 0.1
[HDR] _GlowColor ("Color glow", Color) = (1,1,1,1)
_GlowIntensity   ("Intensidad glow", Float) = 2.0
    }

    SubShader
    {
Tags { "RenderType"="TransparentCutout" "Queue"="Overlay+1" }

        Pass
        {
            Tags { "LightMode"="ForwardBase" }

            Stencil { Ref 1  Comp Always  Pass Replace }
            ZWrite Off
            ZTest Always
            Offset -1, -1
            Cull Off

            CGPROGRAM
            #pragma vertex   vert
            #pragma fragment frag
            #pragma multi_compile_fwdbase
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "AutoLight.cginc"

            sampler2D _MainTex;
            fixed4    _Color;
            float     _Cutoff;
fixed4 _GlowColor;
float  _GlowIntensity;

            struct appdata
            {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 uv     : TEXCOORD0;
            };

            struct v2f
            {
                float4 pos         : SV_POSITION;
                float2 uv          : TEXCOORD0;
                float3 worldNormal : TEXCOORD1;
                SHADOW_COORDS(2)
            };

            v2f vert(appdata v)
            {
                v2f o;
                o.pos         = UnityObjectToClipPos(v.vertex);
                o.uv          = v.uv;
                o.worldNormal = UnityObjectToWorldNormal(v.normal);
                TRANSFER_SHADOW(o);

                return o;
            }

            fixed4 frag(v2f i) : SV_Target
            {
                fixed4 tex = tex2D(_MainTex, i.uv) * _Color;

                clip(tex.a - _Cutoff);

                fixed3 normal   = normalize(i.worldNormal);
                fixed3 lightDir = normalize(_WorldSpaceLightPos0.xyz);
                fixed  NdotL    = max(0, dot(normal, lightDir));
                fixed  shadow   = SHADOW_ATTENUATION(i);

                fixed3 ambient = UNITY_LIGHTMODEL_AMBIENT.rgb * tex.rgb;
                fixed3 diffuse = _LightColor0.rgb * tex.rgb * NdotL * shadow;
fixed3 glow  = _GlowColor.rgb * _GlowIntensity * tex.a;
return fixed4(ambient + diffuse + glow, 1);
                return fixed4(ambient + diffuse, 1);
            }
            ENDCG
        }

        Pass
        {
            Tags { "LightMode"="ForwardAdd" }
            Blend One One
            ZWrite Off
            ZTest Always
            Cull Off

            CGPROGRAM
            #pragma vertex   vert
            #pragma fragment fragAdd
            #pragma multi_compile_fwdadd_fullshadows
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "AutoLight.cginc"

            sampler2D _MainTex;
            fixed4    _Color;
            float     _Cutoff;

            struct appdata { float4 vertex:POSITION; float3 normal:NORMAL; float2 uv:TEXCOORD0; };
            struct v2f { float4 pos:SV_POSITION; float2 uv:TEXCOORD0; float3 worldNormal:TEXCOORD1; LIGHTING_COORDS(2,3) };

            v2f vert(appdata v)
            {
                v2f o;
                o.pos         = UnityObjectToClipPos(v.vertex);
                o.uv          = v.uv;
                o.worldNormal = UnityObjectToWorldNormal(v.normal);
                TRANSFER_VERTEX_TO_FRAGMENT(o);
                return o;
            }

            fixed4 fragAdd(v2f i) : SV_Target
            {
                fixed4 tex = tex2D(_MainTex, i.uv) * _Color;
                clip(tex.a - _Cutoff);

                fixed3 normal   = normalize(i.worldNormal);
                fixed3 lightDir = normalize(_WorldSpaceLightPos0.xyz);
                fixed  NdotL    = max(0, dot(normal, lightDir));
                fixed  atten    = LIGHT_ATTENUATION(i);

                return fixed4(_LightColor0.rgb * tex.rgb * NdotL * atten, 0);
            }
            ENDCG
        }
    }
}