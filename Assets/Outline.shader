Shader "Custom/ToonOutlineFromCenter_Terror"
{
    Properties
    {
        _MainColor ("Model Color", Color) = (1,1,1,1)
        _OutlineColor ("Outline Color", Color) = (1,0,0,1)
        _OutlineWidth ("Outline Width", Range(0.0,0.5)) = 0.05
        _Center ("Model Center (Object Space)", Vector) = (0,0,0,0)
    }

    SubShader
    {
        Tags { "RenderType"="Opaque" }

        Pass
        {
            Name "BASE"
            Cull Back
            ZWrite On

            CGPROGRAM
            #pragma vertex vertBase
            #pragma fragment fragBase
            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
            };

            struct v2f
            {
                float4 pos : SV_POSITION;
            };

            fixed4 _MainColor;

            v2f vertBase(appdata v)
            {
                v2f o;
                o.pos = UnityObjectToClipPos(v.vertex);
                return o;
            }

            fixed4 fragBase(v2f i) : SV_Target
            {
                return _MainColor;
            }
            ENDCG
        }

        Pass
        {
            Name "OUTLINE"
            Cull Front
            ZWrite On
            Blend SrcAlpha OneMinusSrcAlpha

            CGPROGRAM
            #pragma vertex vertOutline
            #pragma fragment fragOutline
            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
            };

            struct v2f
            {
                float4 pos : SV_POSITION;
            };

            float _OutlineWidth;
            float4 _OutlineColor;
            float4 _Center;

            v2f vertOutline(appdata v)
            {
                v2f o;

                float3 dir = normalize(v.vertex.xyz - _Center.xyz);

                float3 expandedPos = v.vertex.xyz + dir * _OutlineWidth;

                float noise = sin(_Time.y * 20.0 + dot(v.vertex.xyz, float3(12.9898,78.233,45.164)));
                expandedPos += dir * noise * _OutlineWidth * 0.2;

                o.pos = UnityObjectToClipPos(float4(expandedPos,1));
                return o;
            }

            fixed4 fragOutline(v2f i) : SV_Target
            {
                float pulse = 0.5 + 0.5 * sin(_Time.y * 10.0);
                fixed3 dark = _OutlineColor.rgb * 0.3;
                fixed3 finalCol = lerp(dark, _OutlineColor.rgb, pulse);
                return fixed4(finalCol, _OutlineColor.a);
            }

            ENDCG
        }
    }

    FallBack "Diffuse"
}