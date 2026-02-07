Shader "Retro1/RetroPostProcess"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}

        _PixelSize ("Pixel Size", Range(1, 1000)) = 160
        _ColorLevels ("Color Levels", Range(2, 256)) = 16
        _ScanlineIntensity ("Scanline Intensity", Range(0, 1)) = 0.25
        _ScanlineCount ("Scanline Count", Range(100, 2000)) = 480
    }

    SubShader
    {
        Tags { "RenderType"="Opaque" }
        Pass
        {
            ZTest Always Cull Off ZWrite Off

            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"

            sampler2D _MainTex;
            float4 _MainTex_TexelSize;

            float _PixelSize;
            float _ColorLevels;
            float _ScanlineIntensity;
            float _ScanlineCount;

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

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }

            float4 frag (v2f i) : SV_Target
            {
                float2 pixelUV = floor(i.uv * _PixelSize) / _PixelSize;

                float4 col = tex2D(_MainTex, pixelUV);

                col.rgb = floor(col.rgb * _ColorLevels) / _ColorLevels;

                float scan = sin(i.uv.y * _ScanlineCount) * 0.5 + 0.5;
                col.rgb *= lerp(1.0, scan, _ScanlineIntensity);

                return col;
            }
            ENDCG
        }
    }
}