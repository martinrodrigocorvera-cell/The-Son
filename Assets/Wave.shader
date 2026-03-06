Shader "Custom/AirRipple"
{
    Properties
    {
        _DistortionStrength ("Distortion Strength",   Range(0, 1))  = 0.03
        _Amplitude          ("Amplitude",             Range(0, 1))    = 0.5
        _Frequency          ("Frequency",             Range(0, 100))  = 30.0
        _Speed              ("Speed",                 Range(0, 20))   = 4.0
        _Transparency       ("Transparency",          Range(0, 1))    = 0.8
        _Fade               ("Edge Fade",             Range(0, 1))    = 0.6

        _EvilColor          ("Evil Glow Color",       Color)          = (0.4, 0.0, 0.8, 1.0)
        _GlowIntensity      ("Glow Intensity",        Range(0, 5))    = 1.5
        _ChromaticAberration("Chromatic Aberration",  Range(0, 0.02)) = 0.006
        _TurbulenceStrength ("Turbulence Strength",   Range(0, 0.05)) = 0.015
        _TurbulenceSpeed    ("Turbulence Speed",      Range(0, 10))   = 2.5
        _FlickerSpeed       ("Flicker Speed",         Range(0, 20))   = 6.0
        _FlickerAmount      ("Flicker Amount",        Range(0, 1))    = 0.2
    }

    SubShader
    {
        Tags { "Queue"="Transparent" "RenderType"="Transparent" "IgnoreProjector"="True" }

        GrabPass { "_GrabTexture" }

        Pass
        {
            ZWrite Off
            Blend SrcAlpha OneMinusSrcAlpha

            CGPROGRAM
            #pragma vertex   vert
            #pragma fragment frag
            #include "UnityCG.cginc"

            sampler2D _GrabTexture;

            float  _DistortionStrength;
            float  _Amplitude;
            float  _Frequency;
            float  _Speed;
            float  _Transparency;
            float  _Fade;

            float4 _EvilColor;
            float  _GlowIntensity;
            float  _ChromaticAberration;
            float  _TurbulenceStrength;
            float  _TurbulenceSpeed;
            float  _FlickerSpeed;
            float  _FlickerAmount;

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv     : TEXCOORD0;
            };

            struct v2f
            {
                float4 grabPos : TEXCOORD0;
                float2 uv      : TEXCOORD1;
                float4 pos     : SV_POSITION;
            };

            float2 hash2(float2 p)
            {
                p = float2(dot(p, float2(127.1, 311.7)),
                           dot(p, float2(269.5, 183.3)));
                return -1.0 + 2.0 * frac(sin(p) * 43758.5453);
            }

            float noise(float2 p)
            {
                float2 i = floor(p);
                float2 f = frac(p);
                float2 u = f * f * (3.0 - 2.0 * f);

                return lerp(lerp(dot(hash2(i + float2(0,0)), f - float2(0,0)),
                                 dot(hash2(i + float2(1,0)), f - float2(1,0)), u.x),
                            lerp(dot(hash2(i + float2(0,1)), f - float2(0,1)),
                                 dot(hash2(i + float2(1,1)), f - float2(1,1)), u.x), u.y);
            }

            v2f vert(appdata v)
            {
                v2f o;
                o.pos     = UnityObjectToClipPos(v.vertex);
                o.grabPos = ComputeGrabScreenPos(o.pos);
                o.uv      = v.uv;
                return o;
            }

            fixed4 frag(v2f i) : SV_Target
            {
                float  t         = _Time.y;
                float2 delta     = i.uv - float2(0.5, 0.5);
                float  dist      = length(delta);
                float2 direction = dist > 0.001 ? normalize(delta) : float2(0, 0);

                float wave = sin(dist * _Frequency - t * _Speed) * _Amplitude;

                float2 turbUV = i.uv * 4.0 + t * _TurbulenceSpeed * float2(0.7, 1.0);
                float  turb   = noise(turbUV) * noise(turbUV * 1.7 + float2(3.1, 1.7));
                float2 turbOffset = float2(
                    noise(turbUV + float2(0.0, t * 0.3)),
                    noise(turbUV + float2(5.2, t * 0.3))
                ) * _TurbulenceStrength;

                float2 baseOffset = direction * wave * _DistortionStrength + turbOffset;

                float  chromaScale = _ChromaticAberration;
                float2 grabUV_R = (i.grabPos.xy + (baseOffset + direction * chromaScale) * i.grabPos.w) / i.grabPos.w;
                float2 grabUV_G = (i.grabPos.xy +  baseOffset                            * i.grabPos.w) / i.grabPos.w;
                float2 grabUV_B = (i.grabPos.xy + (baseOffset - direction * chromaScale) * i.grabPos.w) / i.grabPos.w;

                fixed4 sceneR = tex2D(_GrabTexture, grabUV_R);
                fixed4 sceneG = tex2D(_GrabTexture, grabUV_G);
                fixed4 sceneB = tex2D(_GrabTexture, grabUV_B);

                fixed4 scene = fixed4(sceneR.r, sceneG.g, sceneB.b, sceneG.a);

                float ringMask  = abs(sin(dist * _Frequency - t * _Speed));
                float edgeMask  = smoothstep(0.1, 0.45, dist);    
                float turbGlow  = saturate(turb * 0.5 + 0.5);       
                float glowMask  = ringMask * edgeMask * turbGlow;

                scene.rgb = lerp(scene.rgb,
                                 scene.rgb + _EvilColor.rgb * _GlowIntensity,
                                 glowMask * 0.6);

                float flicker = 1.0 - _FlickerAmount * (sin(t * _FlickerSpeed) * 0.5 + 0.5)
                                                      * (sin(t * _FlickerSpeed * 2.3 + 1.7) * 0.5 + 0.5);

                float centerFade = smoothstep(0.0, 0.05, dist);
                float edgeFade   = 1.0 - smoothstep(0.5 - _Fade * 0.5, 0.5, dist);
                float alpha      = centerFade * edgeFade * _Transparency * flicker;

                scene.a = alpha;
                return scene;
            }
            ENDCG
        }
    }

    FallBack Off
}