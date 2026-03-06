Shader "Custom/portal"
{
    Properties
    {
        _MainTex         ("Render Texture (interior)", 2D) = "black" {}
        _NoiseTex        ("Noise Texture",             2D) = "white" {}
        _CoreColor       ("Color nucleo",        Color) = (0.05, 0.0,  0.10, 1)
        _EdgeColor       ("Color borde",         Color) = (0.80, 0.0,  1.00, 1)
        _VoidColor       ("Color vacio",         Color) = (0.00, 0.0,  0.00, 1)
        _ArcColor        ("Color arcos",         Color) = (0.60, 0.0,  1.00, 1)
        _RingColor       ("Color anillos",       Color) = (0.20, 0.0,  0.40, 1)
        _SwirlSpeed      ("Vel. torbellino",     Float) = 1.5
        _SwirlStrength   ("Fuerza torbellino",   Float) = 3.5
        _DistortStrength ("Distorsion ruido",    Float) = 0.06
        _EdgeWidth       ("Ancho borde",         Float) = 0.25
        _EdgePower       ("Potencia borde",      Float) = 2.5
        _PulseSpeed      ("Vel. pulso",          Float) = 2.0
        _PulseAmount     ("Amplitud pulso",      Float) = 0.10
        _VoidRadius      ("Radio vacio",         Float) = 0.15
        _PortalRadius    ("Radio portal",        Float) = 0.48
        _EmissionStrength("Intensidad emision",  Float) = 4.0
        _ArcIntensity    ("Intensidad arcos",    Float) = 1.5
        _RingCount       ("Num. anillos",        Float) = 5.0
        _TendrilCount    ("Num. tendrils",       Float) = 12.0
    }

    SubShader
    {
        Tags { "RenderType"="Transparent" "Queue"="Transparent" }
        Blend One OneMinusSrcAlpha
        ZWrite Off
        Cull Off

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma multi_compile_fog
            #include "UnityCG.cginc"

            sampler2D _MainTex;
            sampler2D _NoiseTex;
            float4    _MainTex_ST;

            fixed4 _CoreColor;
            fixed4 _EdgeColor;
            fixed4 _VoidColor;
            fixed4 _ArcColor;
            fixed4 _RingColor;
            float  _SwirlSpeed;
            float  _SwirlStrength;
            float  _DistortStrength;
            float  _EdgeWidth;
            float  _EdgePower;
            float  _PulseSpeed;
            float  _PulseAmount;
            float  _VoidRadius;
            float  _PortalRadius;
            float  _EmissionStrength;
            float  _ArcIntensity;
            float  _RingCount;
            float  _TendrilCount;

            #define PI     3.14159265
            #define TWO_PI 6.28318530

            struct appdata { float4 vertex : POSITION; float2 uv : TEXCOORD0; };
            struct v2f     { float4 pos : SV_POSITION; float2 uv : TEXCOORD0; UNITY_FOG_COORDS(1) };


            float2 Rotate2D(float2 uv, float a)
            {
                float s = sin(a), c = cos(a);
                uv -= 0.5;
                uv = float2(c*uv.x - s*uv.y, s*uv.x + c*uv.y);
                return uv + 0.5;
            }

            float Hash(float n) { return frac(sin(n) * 43758.5453); }
            float Hash2(float2 p) { return frac(sin(dot(p, float2(127.1, 311.7))) * 43758.5453); }

            float Fbm(float2 uv, float timeOffset)
            {
                float v = 0.0;
                float amp = 0.50;
                float freq = 1.00;
                [unroll]
                for (int o = 0; o < 4; o++)
                {
                    float2 s = frac(uv * freq + float2(timeOffset * 0.05 * (o+1),
                                                       timeOffset * 0.03 * (o+1) + o));
                    v   += amp * tex2D(_NoiseTex, s).r;
                    amp  *= 0.50;
                    freq *= 2.13;
                }
                return v;
            }

            float ElectricArc(float angle, float dist, float noiseOffset, float freq, float t)
            {
                float a = angle * freq + noiseOffset * TWO_PI + t * _SwirlSpeed * 0.8;
                float arc = pow(max(0.0, sin(a)), 12.0);                  // pico fino
                arc += pow(max(0.0, sin(a * 1.73 + 1.1)), 16.0) * 0.5;   // armonica secundaria
                arc *= (1.0 - dist);                                       // se desvanece al borde
                arc *= smoothstep(0.05, 0.25, dist);                       // sin arco en el vacio
                return arc;
            }

            float Ring(float distN, float r, float w)
            {
                return 1.0 - smoothstep(0.0, w, abs(distN - r));
            }

            v2f vert(appdata v)
            {
                v2f o;
                o.pos = UnityObjectToClipPos(v.vertex);
                o.uv  = TRANSFORM_TEX(v.uv, _MainTex);
                UNITY_TRANSFER_FOG(o, o.pos);
                return o;
            }

            fixed4 frag(v2f i) : SV_Target
            {
                float2 uv = i.uv;
                float  t  = _Time.y;

                float2 centered = uv - 0.5;
                float  dist     = length(centered);
                float  angle    = atan2(centered.y, centered.x);

                float portalMask = 1.0 - smoothstep(_PortalRadius, _PortalRadius + 0.025, dist);
                clip(portalMask - 0.001);

                float pulse = 1.0
                    + _PulseAmount        * sin(t * _PulseSpeed)
                    + _PulseAmount * 0.45 * sin(t * _PulseSpeed * 2.7 + 1.3)
                    + _PulseAmount * 0.20 * sin(t * _PulseSpeed * 5.1 + 0.7)
                    + _PulseAmount * 0.10 * sin(t * _PulseSpeed * 9.3 + 2.1);

                float distN = saturate(dist / (_PortalRadius * pulse));

                float swirl1 = (_SwirlStrength / (dist + 0.05)) * sin(t * _SwirlSpeed * 0.7 + dist * 5.0)
                             + t * _SwirlSpeed * 0.35;
                float2 swirlUV1 = Rotate2D(uv, swirl1);

                float swirl2 = -(_SwirlStrength * 0.6 / (dist + 0.08)) * sin(t * _SwirlSpeed * 1.1 + dist * 3.0)
                             - t * _SwirlSpeed * 0.55;
                float2 swirlUV2 = Rotate2D(uv, swirl2);

                float fbm1 = Fbm(swirlUV1, t);
                float fbm2 = Fbm(swirlUV2, t * 1.3 + 7.7);

                float2 warpOffset = float2(fbm2 - 0.5, fbm1 - 0.5) * 0.35;
                float  fbmWarped  = Fbm(swirlUV1 + warpOffset, t * 0.8);

                float nFine = tex2D(_NoiseTex, frac(swirlUV1 * 7.0 + float2(t*0.17, -t*0.13))).r;

                float2 dOff  = float2(fbm1 - 0.5, fbm2 - 0.5) * _DistortStrength;
                float2 rtUV  = Rotate2D(uv + dOff, t * _SwirlSpeed * 0.2);
                fixed4 rtCol = tex2D(_MainTex, rtUV);

                float  ch   = 0.025 * distN * distN;
                float2 cDir = normalize(centered + 1e-5) * ch;
                rtCol.r = tex2D(_MainTex, rtUV + cDir       ).r;
                rtCol.g = tex2D(_MainTex, rtUV + cDir * 0.4 ).g;
                rtCol.b = tex2D(_MainTex, rtUV - cDir       ).b;

                float arc  = ElectricArc(angle, distN, fbmWarped, _TendrilCount,       t);
                arc += 0.6 * ElectricArc(angle, distN, fbm2,      _TendrilCount * 1.5, t + 1.0);
                arc += 0.4 * ElectricArc(angle, distN, fbm1,      _TendrilCount * 0.7, t + 2.3);
                arc += 0.3 * ElectricArc(angle, distN, nFine,     _TendrilCount * 2.3, t * 1.4);
                arc *= _ArcIntensity;

                float ringMask = 0.0;
                float ringStep = 1.0 / (_RingCount + 1.0);
                for (int r = 1; r <= 5; r++)
                {
                    float rPos  = r * ringStep;
                    float rAnim = rPos + 0.04 * sin(t * _PulseSpeed * 1.5 + r * 1.7);
                    float rW    = 0.018 + 0.008 * sin(t * _PulseSpeed + r);
                    float rMask = Ring(distN, rAnim, rW);
                    // intensidad mayor en anillos interiores
                    ringMask += rMask * (1.0 - rPos * 0.5);
                }
                ringMask = saturate(ringMask);

                float spark = 0.0;
                for (int s = 0; s < 8; s++)
                {
                    float sAngle = TWO_PI * Hash(s * 7.31) + t * _SwirlSpeed * (0.3 + Hash(s) * 0.7);
                    float sDist  = 0.55 + 0.25 * Hash(s * 3.17) + 0.08 * sin(t * 2.0 + s);
                    float2 sPos  = float2(cos(sAngle), sin(sAngle)) * sDist * _PortalRadius + 0.5;
                    float  sDiff = length(uv - sPos);
                    spark += 0.004 / (sDiff * sDiff + 0.001) * smoothstep(1.0, 0.8, distN);
                }
                spark = saturate(spark);

                float scanFreq  = 18.0;
                float scanAnim  = distN * scanFreq - t * 3.0;
                float scanline  = 0.5 + 0.5 * sin(scanAnim + fbm1 * PI);
                scanline = pow(scanline, 3.0) * 0.25;

                float flicker = 1.0
                    - 0.08 * Hash(floor(t * 23.0))
                    - 0.05 * Hash(floor(t * 7.0) + 1.0)
                    - 0.03 * sin(t * 47.3);

                float edgeFactor = 1.0 - distN;
                float edgeGlow   = pow(saturate(1.0 - smoothstep(0.0, _EdgeWidth, edgeFactor)), _EdgePower) * pulse;
                // segundo borde interior mas suave
                float innerGlow  = pow(saturate(1.0 - smoothstep(0.0, _EdgeWidth * 2.5, edgeFactor)), _EdgePower * 0.6) * 0.5;

                float voidMask = smoothstep(_VoidRadius, _VoidRadius + 0.10, distN);

                fixed3 fbmColor  = lerp(_VoidColor.rgb, _CoreColor.rgb, fbmWarped * voidMask);
                fbmColor        += _CoreColor.rgb * nFine * 0.3 * voidMask;

                fixed3 interior  = lerp(fbmColor, rtCol.rgb, voidMask * (1.0 - fbm1 * 0.4) * 0.6);

                interior        += scanline * _CoreColor.rgb * voidMask;

                fixed3 arcLayer  = _ArcColor.rgb * arc * flicker;

                fixed3 ringLayer = _RingColor.rgb * ringMask * (0.6 + 0.4 * pulse);

                fixed3 sparkLayer = _EdgeColor.rgb * spark * flicker;

                fixed3 edgeLayer = _EdgeColor.rgb * (edgeGlow + innerGlow) * _EmissionStrength * flicker;

                fixed3 finalColor = interior
                                  + arcLayer
                                  + ringLayer
                                  + sparkLayer
                                  + edgeLayer
                                  + fbm2 * _CoreColor.rgb * 0.2 * (1.0 - distN);

                float alpha = portalMask
                            * lerp(0.80, 1.0, 1.0 - distN)
                            * flicker;

                fixed4 col = fixed4(finalColor * alpha, alpha);
                UNITY_APPLY_FOG(i.fogCoords, col);
                return col;
            }
            ENDCG
        }
    }
    FallBack "Transparent/Diffuse"
}