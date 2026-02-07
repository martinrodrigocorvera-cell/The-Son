Shader "Retro/RetroUICompatible"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _PixelSize ("Pixel Size", Range(1, 256)) = 64
        _ColorLevels ("Color Levels", Range(2, 16)) = 8
        _ScanlineIntensity ("Scanline Intensity", Range(0,1)) = 0.2
        _ScanlineCount ("Scanline Count", Range(100, 2000)) = 300
        _ColorTint ("Color Tint", Color) = (1,1,1,1)
    }

    SubShader
    {
        Tags { "Queue"="Transparent" "IgnoreProjector"="True" "RenderType"="Transparent" }
        LOD 100
        Cull Off
        Lighting Off
        ZWrite Off
        Blend SrcAlpha OneMinusSrcAlpha

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"

            sampler2D _MainTex;
            float4 _ColorTint;
            float _PixelSize;
            float _ColorLevels;
            float _ScanlineIntensity;
            float _ScanlineCount;
            float4 _MainTex_ST;

            struct appdata_t
            {
                float4 vertex : POSITION;
                float2 texcoord : TEXCOORD0;
            };

            struct v2f
            {
                float4 vertex : SV_POSITION;
                float2 uv : TEXCOORD0;
            };

            v2f vert(appdata_t v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.texcoord, _MainTex);
                return o;
            }

            float3 QuantizeColor(float3 col, float levels)
            {
                return floor(col * levels) / levels;
            }

            float4 frag(v2f i) : SV_Target
            {
                // Pixelizado
                float2 pixelUV = floor(i.uv * _PixelSize) / _PixelSize;
                float4 col = tex2D(_MainTex, pixelUV) * _ColorTint;

                // Reducción de color
                col.rgb = QuantizeColor(col.rgb, _ColorLevels);

                // Scanlines
                float scan = sin(i.uv.y * _ScanlineCount) * 0.5 + 0.5;
                col.rgb *= lerp(1.0, scan, _ScanlineIntensity);

                return col;
            }
            ENDCG
        }
    }
}
