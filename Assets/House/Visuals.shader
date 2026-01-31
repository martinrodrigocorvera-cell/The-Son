Shader "Custom/Visuals"
{
    Properties
    {
        _MainTex("Base (Current Frame)", 2D) = "white" {}
        _Intensity("Effect Intensity", Range(0,1)) = 0.6
        _NoiseStrength("Noise Strength", Range(0,1)) = 0.05
        _Aberration("Chromatic Aberration", Range(0,1)) = 0.02
        _ScanlineStrength("Scanline Strength", Range(0,1)) = 0.05
        _MotionScale("Motion Scale", Range(0,1)) = 0.2
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        Pass
        {
            ZTest Always Cull Off ZWrite Off
            Fog { Mode Off }

            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            float _Intensity;
            float _NoiseStrength;
            float _Aberration;
            float _ScanlineStrength;
            float _MotionScale;
            float4 _MainTex_TexelSize;

            v2f vert(appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }

            fixed4 frag(v2f i) : SV_Target
            {
                float2 uv = i.uv;

                // --- Chromatic Aberration (suave) ---
                float speed = 0.3; // más lento
                float2 offset = (_Aberration * _MotionScale * 0.002) * float2(cos(_Time.y * speed), sin(_Time.y * speed));
                float r = tex2D(_MainTex, uv + offset).r;
                float g = tex2D(_MainTex, uv).g;
                float b = tex2D(_MainTex, uv - offset).b;

                float3 col = float3(r,g,b);

                // --- Scanlines suaves ---
                float scanline = sin(uv.y * _ScreenParams.y * 3.0) * _ScanlineStrength;
                col *= (1.0 - scanline);

                // --- Ruido ligero ---
                float noise = frac(sin(dot(uv * _Time.y * 0.5, float2(12.9898,78.233))) * 43758.5453);
                col += (noise - 0.5) * _NoiseStrength;

                // --- Mezcla con original ---
                float3 original = tex2D(_MainTex, uv).rgb;
                col = lerp(original, col, _Intensity);

                return fixed4(col, 1.0);
            }
            ENDCG
        }
    }
}
