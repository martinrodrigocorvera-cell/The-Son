Shader "Custom/VFX_LightningTrail"
{
    Properties
    {
        _Color           ("Color base",          Color)  = (0.5, 0.0, 1.0, 1)
        _EmissionStrength("Intensidad emision",   Float)  = 6.0
        _CoreWidth       ("Ancho nucleo",         Float)  = 0.15
        _NoiseFreq       ("Frec. irregularidad",  Float)  = 10.0
        _NoiseSpeed      ("Vel. irregularidad",   Float)  = 20.0
        _NoiseAmp        ("Amp. irregularidad",   Float)  = 0.28
        _GlowRadius      ("Radio glow exterior",  Float)  = 0.5
        _GlowIntensity   ("Intensidad glow",      Float)  = 1.8
    }

    SubShader
    {
        Tags { "RenderType"="Transparent" "Queue"="Transparent" }
        Blend One One      
        ZWrite Off
        Cull Off

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"

            fixed4 _Color;
            float  _EmissionStrength;
            float  _CoreWidth;
            float  _NoiseFreq;
            float  _NoiseSpeed;
            float  _NoiseAmp;
            float  _GlowRadius;
            float  _GlowIntensity;

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv     : TEXCOORD0;
                fixed4 color  : COLOR;
            };

            struct v2f
            {
                float4 pos   : SV_POSITION;
                float2 uv    : TEXCOORD0;
                fixed4 color : COLOR;
            };

            float LightningNoise(float v, float t)
            {
                return   sin(v * _NoiseFreq         + t * _NoiseSpeed)        * 0.500
                       + sin(v * _NoiseFreq * 2.37  + t * _NoiseSpeed * 1.61) * 0.250
                       + sin(v * _NoiseFreq * 5.13  + t * _NoiseSpeed * 0.71) * 0.125
                       + sin(v * _NoiseFreq * 11.47 + t * _NoiseSpeed * 2.19) * 0.063
                       + sin(v * _NoiseFreq * 23.91 + t * _NoiseSpeed * 3.37) * 0.031;
            }

            v2f vert(appdata v)
            {
                v2f o;
                o.pos   = UnityObjectToClipPos(v.vertex);
                o.uv    = v.uv;
                o.color = v.color;
                return o;
            }

            fixed4 frag(v2f i) : SV_Target
            {
                float u = i.uv.x;
                float v = i.uv.y;
                float t = _Time.y;

                float uc = u - 0.5;

                float noise       = LightningNoise(v, t);
                float halfWidth   = 0.5 + noise * _NoiseAmp;
                float absUc       = abs(uc);

                float core = 1.0 - smoothstep(0.0, _CoreWidth, absUc);
                core = pow(core, 1.8);

                float body = 1.0 - smoothstep(halfWidth - 0.12, halfWidth, absUc);

                float glowHW  = halfWidth + _GlowRadius * 0.5;
                float glow    = 1.0 - smoothstep(halfWidth, glowHW, absUc);
                glow = pow(glow, 2.5) * _GlowIntensity;

                float edgeClip = 1.0 - smoothstep(halfWidth, halfWidth + 0.04, absUc);

                float lengthFade = pow(1.0 - v, 0.7);

                float flicker = 0.85
                              + 0.15 * sin(t * 73.0 + v * 17.0)
                              + 0.08 * sin(t * 131.0 + v * 43.0);

                float brightness = (core * 1.0 + body * 0.4 + glow * 0.2)
                                 * edgeClip
                                 * lengthFade
                                 * flicker;

                fixed3 coreColor = fixed3(0.85, 0.70, 1.00);
                fixed3 bodyColor = _Color.rgb;     
                fixed3 glowColor = _Color.rgb * fixed3(0.6, 0.0, 1.0); 

                fixed3 col = coreColor * core  * _EmissionStrength
                           + bodyColor * body  * (_EmissionStrength * 0.5)
                           + glowColor * glow  * _GlowIntensity;

                col *= lengthFade * flicker * edgeClip;

                float alpha = brightness * i.color.a;

                return fixed4(col * i.color.a, alpha);
            }
            ENDCG
        }
    }
}