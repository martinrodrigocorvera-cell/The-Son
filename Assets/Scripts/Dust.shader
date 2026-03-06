

Shader "Custom/Dust"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _DissolvePercent ("Dissolve Percent", Range(0,1)) = 0
        _EdgeWidth ("Edge Width", Float) = 0.2
        _EdgeColor ("Edge Color", Color) = (1,0.5,0,1)
_NoiseTex ("Noise Texture", 2D) = "white" {}
_DustIntensity ("Dust Intensity", Range(0,5)) = 1
_DustSpeed ("Dust Speed", Float) = 1
    }

    SubShader
    {
        Tags { "RenderType"="Transparent" "Queue"="Transparent" }
        LOD 200
        ZWrite On

        CGPROGRAM
        #pragma surface surf Standard alphatest:_Cutoff

        sampler2D _MainTex;
        float _DissolvePercent;
        float _EdgeWidth;
        fixed4 _EdgeColor;

        struct Input
        {
            float2 uv_MainTex;
            float3 worldPos;
        };

        void surf(Input IN, inout SurfaceOutputStandard o)
        {
            fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
            o.Albedo = c.rgb;
            o.Alpha = 1;

            float meshTop = unity_ObjectToWorld._m13 + 1.5f * unity_ObjectToWorld._m11;   // aprox top
            float meshBottom = unity_ObjectToWorld._m13 - 2 * unity_ObjectToWorld._m11; // aprox bottom

            float dissolveHeight = lerp(meshTop, meshBottom, _DissolvePercent);

            float dissolve = IN.worldPos.y - dissolveHeight;

if (dissolve > 0)
{
    clip(-1);
}

if (dissolve <= 0 && dissolve > -_EdgeWidth)
{
    o.Albedo = _EdgeColor.rgb;
}
        }
        ENDCG
    }

    FallBack "Diffuse"
}
