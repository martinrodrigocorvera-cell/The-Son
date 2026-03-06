Shader "Custom/EvilEssence"
{
    Properties
    {
        _MainTex         ("Textura base",        2D)    = "white" {}
        _EssenceColor    ("Color esencia",       Color) = (0.15, 0.0, 0.25, 1)
        _RimColor        ("Color rim maligno",   Color) = (0.4,  0.0, 0.8,  1)
        _SmokeColor      ("Color humo",          Color) = (0.05, 0.0, 0.1,  1)
        _RimPower        ("Potencia rim",        Float) = 3.0
        _RimIntensity    ("Intensidad rim",      Float) = 2.5
        _NoiseScale      ("Escala ruido",        Float) = 3.5
        _NoiseSpeed      ("Velocidad ruido",     Float) = 0.6
        _CorruptionAmt   ("Corrupcion",          Range(0,1)) = 0.7
        _PulseSpeed      ("Velocidad pulso",     Float) = 1.8
        _PulseAmount     ("Amplitud pulso",      Float) = 0.3
        _DissolveEdge    ("Borde disolucion",    Float) = 0.08
        _DarknessPower   ("Oscurecimiento",      Float) = 2.2
        _EmissionStrength("Emision",             Float) = 1.5
    }

    SubShader
    {
        Tags { "RenderType"="Opaque" "Queue"="Geometry" }
        Cull Back

        CGPROGRAM
        #pragma surface surf Standard fullforwardshadows vertex:vert
        #pragma target 3.0

        sampler2D _MainTex;
        fixed4  _EssenceColor;
        fixed4  _RimColor;
        fixed4  _SmokeColor;
        float   _RimPower;
        float   _RimIntensity;
        float   _NoiseScale;
        float   _NoiseSpeed;
        float   _CorruptionAmt;
        float   _PulseSpeed;
        float   _PulseAmount;
        float   _DissolveEdge;
        float   _DarknessPower;
        float   _EmissionStrength;

        float Hash(float2 p)
        {
            p = frac(p * float2(127.1, 311.7));
            p += dot(p, p + 19.19);
            return frac(p.x * p.y);
        }

        float ValueNoise(float2 p)
        {
            float2 i = floor(p);
            float2 f = frac(p);
            float2 u = f * f * (3.0 - 2.0 * f);

            float a = Hash(i);
            float b = Hash(i + float2(1,0));
            float c = Hash(i + float2(0,1));
            float d = Hash(i + float2(1,1));

            return lerp(lerp(a, b, u.x), lerp(c, d, u.x), u.y);
        }

        float Fbm(float2 p)
        {
            float v = 0.0;
            float amp = 0.5;
            float2x2 rot = float2x2(1.6, 1.2, -1.2, 1.6);
            for (int i = 0; i < 5; i++)
            {
                v   += amp * ValueNoise(p);
                p    = mul(rot, p) * 2.1;
                amp *= 0.45;
            }
            return v;
        }

struct Input
{
    float2 uv_MainTex;
    float3 worldPos;
    float3 worldNormal;
    float3 viewDir;
};

void vert(inout appdata_full v)
{
    float t     = _Time.y * _NoiseSpeed;
    float2 nuv  = v.vertex.xz * _NoiseScale * 0.3 + float2(0, t);
    float  disp = Fbm(nuv) - 0.5;

    float pulse = sin(_Time.y * _PulseSpeed) * 0.5 + 0.5;
    v.vertex.xyz += v.normal * disp * _CorruptionAmt * 0.04 * (0.7 + pulse * 0.3);
}


        void surf(Input IN, inout SurfaceOutputStandard o)
        {
            float t = _Time.y * _NoiseSpeed;

float2 uv1  = IN.worldPos.xz * _NoiseScale * 0.5 + float2(sin(t * 0.3) * 0.1, t);
float  n1   = Fbm(uv1);

float2 warp = float2(Fbm(uv1 + float2(1.7, 9.2)), Fbm(uv1 + float2(8.3, 2.8)));
float2 uv2  = IN.worldPos.xz * (_NoiseScale * 0.75) + warp * 0.4 + float2(-t * 0.5, t * 0.8);
float  n2   = Fbm(uv2);

            float noise = lerp(n1, n2, 0.5);

            float pulse  = sin(_Time.y * _PulseSpeed) * 0.5 + 0.5;
            float pulse2 = sin(_Time.y * _PulseSpeed * 2.3 + 1.5) * 0.5 + 0.5;
            float flicker = 1.0 - _PulseAmount * (pulse * 0.6 + pulse2 * 0.4);

            fixed4 baseTex = tex2D(_MainTex, IN.uv_MainTex);
            fixed3 darkBase = pow(baseTex.rgb, _DarknessPower) * (1.0 - _CorruptionAmt * 0.8);
            fixed3 corruptedBase = lerp(darkBase, _EssenceColor.rgb, _CorruptionAmt * noise);

            float  rim     = 1.0 - saturate(dot(normalize(IN.viewDir), normalize(IN.worldNormal)));
            float  rimMask = pow(rim, _RimPower);
            fixed3 rimCol  = _RimColor.rgb * rimMask * _RimIntensity * flicker;

            float darkRim  = pow(1.0 - rim, 6.0);
            fixed3 darkEdge = _SmokeColor.rgb * darkRim * 2.0;

            float veins = pow(abs(sin(noise * 12.0 + t)), 8.0);
            fixed3 veinColor = _RimColor.rgb * veins * 0.6 * flicker;

            fixed3 col = corruptedBase - darkEdge + veinColor;

            o.Albedo     = saturate(col) * (0.2 + noise * 0.3);
            o.Emission   = (rimCol + veinColor * 0.5 + _EssenceColor.rgb * noise * 0.3 * flicker)
                           * _EmissionStrength;
            o.Metallic   = 0.0;
            o.Smoothness = 0.1 + noise * 0.15;
            o.Occlusion  = 1.0 - noise * 0.4;
        }
        ENDCG
    }

    FallBack "Diffuse"
}