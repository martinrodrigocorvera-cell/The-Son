Shader "Hidden/Invisible"
{
    Properties
    {
        _MainTex        ("Screen",          2D)    = "white" {}
        _DistortStrength("Distorsion",      Float) = 0.008
        _DistortSpeed   ("Vel. distorsion", Float) = 1.2
        _DistortScale   ("Escala ruido",    Float) = 4.0
        _ChromaStrength ("Aberracion",      Float) = 0.004
        _Desaturation   ("Desaturacion",    Range(0,1)) = 0.35
        _VignetteStr    ("Viñeta borde",    Float) = 1.8
        _ShimmerSpeed   ("Vel. shimmer",    Float) = 3.0
        _ShimmerAmt     ("Amp. shimmer",    Float) = 0.06
        _Intensity      ("Intensidad total",Range(0,1)) = 1.0
    }

    SubShader
    {
        Cull Off ZWrite Off ZTest Always

        Pass
        {
            CGPROGRAM
            #pragma vertex   vert
            #pragma fragment frag
            #include "UnityCG.cginc"

            sampler2D _MainTex;
            float4    _MainTex_TexelSize;
            float _DistortStrength;
            float _DistortSpeed;
            float _DistortScale;
            float _ChromaStrength;
            float _Desaturation;
            float _VignetteStr;
            float _ShimmerSpeed;
            float _ShimmerAmt;
            float _Intensity;

            struct appdata { float4 vertex:POSITION; float2 uv:TEXCOORD0; };
            struct v2f    { float4 pos:SV_POSITION;  float2 uv:TEXCOORD0; };

            v2f vert(appdata v)
            {
                v2f o;
                o.pos = UnityObjectToClipPos(v.vertex);
                o.uv  = v.uv;
                return o;
            }

            float Hash(float2 p)
            {
                p = frac(p * float2(127.1, 311.7));
                p += dot(p, p + 19.19);
                return frac(p.x * p.y);
            }

            float ValueNoise(float2 p)
            {
                float2 i = floor(p), f = frac(p);
                float2 u = f * f * (3.0 - 2.0 * f);
                return lerp(
                    lerp(Hash(i), Hash(i+float2(1,0)), u.x),
                    lerp(Hash(i+float2(0,1)), Hash(i+float2(1,1)), u.x), u.y);
            }

            float Fbm(float2 p)
            {
                float v=0, a=0.5;
                for (int i=0;i<4;i++) { v+=a*ValueNoise(p); p=p*2.1+float2(1.7,9.2); a*=0.5; }
                return v;
            }

            fixed4 frag(v2f i) : SV_Target
            {
                float2 uv  = i.uv;
                float  t   = _Time.y;

                float2 noiseUV = uv * _DistortScale + float2(t * _DistortSpeed * 0.7,
                                                              t * _DistortSpeed * 0.5);
                float2 warp    = float2(Fbm(noiseUV),
                                        Fbm(noiseUV + float2(3.1, 1.7)));
                float2 offset  = (warp - 0.5) * _DistortStrength;

                float shimmer  = sin(uv.y * 20.0 + t * _ShimmerSpeed) * 0.5 + 0.5;
                shimmer       *= sin(uv.x * 15.0 - t * _ShimmerSpeed * 0.8) * 0.5 + 0.5;
                offset        += float2(shimmer - 0.5, shimmer - 0.5) * _ShimmerAmt
                                 * (warp - 0.5);

                float2 dir   = normalize(uv - 0.5 + offset);
                float  chroma = _ChromaStrength * (1.0 + shimmer * 0.5);

                float r = tex2D(_MainTex, uv + offset + dir * chroma).r;
                float g = tex2D(_MainTex, uv + offset              ).g;
                float b = tex2D(_MainTex, uv + offset - dir * chroma).b;

                fixed3 col = fixed3(r, g, b);

                float lum  = dot(col, float3(0.299, 0.587, 0.114));
                col        = lerp(col, fixed3(lum, lum, lum), _Desaturation);

col += fixed3(-0.002, -0.002, 0.008) * _Intensity;

                float2 vig  = uv - 0.5;
float vignRaw = dot(vig, vig);
float vign = 1.0 - pow(vignRaw, 1.5f) * _VignetteStr;
                vign        = saturate(vign);

float edgeGlow = pow(1.0 - vign, 2.5) * 0.4 * _Intensity * (0.8 + shimmer * 0.2);
                col           += fixed3(edgeGlow * 0.5, edgeGlow * 0.8, edgeGlow);

                fixed3 original = tex2D(_MainTex, uv).rgb;
                col = lerp(original, col * vign, _Intensity);

                return fixed4(col, 1);
            }
            ENDCG
        }
    }
}