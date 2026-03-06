Shader "Custom/EvilEssenceTop"
{
    Properties
    {
        _MainTex         ("Textura base",        2D)    = "white" {}
        _Color           ("Color tint",          Color) = (1,1,1,1)
        [Toggle(_EMISSION_ON)] _UseEmission ("Enable Glow", Float) = 0
        [HDR] _EmissionColor ("Emission Color",  Color) = (0,0,0,0)
        _EmissionMap     ("Emission Map",        2D)    = "black" {}

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
        _DarknessPower   ("Oscurecimiento",      Float) = 2.2
        _EvilEmission    ("Emision maligna",     Float) = 1.5
    }

    SubShader
    {
        Tags { "RenderType"="Opaque" "Queue"="Overlay" }

        Pass
        {
            Name "ForwardBase"
            Tags { "LightMode"="ForwardBase" }

            Stencil { Ref 1  Comp Always  Pass Replace }
            ZWrite Off
            ZTest Always
            Offset -1, -1

            CGPROGRAM
            #pragma vertex   vert
            #pragma fragment frag
            #pragma multi_compile_fwdbase
            #pragma shader_feature _EMISSION_ON
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "AutoLight.cginc"

            sampler2D _MainTex;
            sampler2D _EmissionMap;
            fixed4  _Color;
            fixed4  _EmissionColor;
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
            float   _DarknessPower;
            float   _EvilEmission;

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
                return lerp(lerp(Hash(i), Hash(i+float2(1,0)), u.x),
                            lerp(Hash(i+float2(0,1)), Hash(i+float2(1,1)), u.x), u.y);
            }

            float Fbm(float2 p)
            {
                float v = 0; float amp = 0.5;
                float2x2 rot = float2x2(1.6, 1.2, -1.2, 1.6);
                for (int i = 0; i < 5; i++)
                {
                    v += amp * ValueNoise(p);
                    p  = mul(rot, p) * 2.1;
                    amp *= 0.45;
                }
                return v;
            }

            struct appdata
            {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 uv     : TEXCOORD0;
            };

            struct v2f
            {
                float4 pos         : SV_POSITION;
                float2 uv          : TEXCOORD0;
                float3 worldNormal : TEXCOORD1;
                float3 worldPos    : TEXCOORD2;
                float3 viewDir     : TEXCOORD3;
                SHADOW_COORDS(4)
            };

            v2f vert(appdata v)
            {
                v2f o;
                float t    = _Time.y * _NoiseSpeed;
                float2 nuv = v.vertex.xz * _NoiseScale * 0.3 + float2(0, t);

                float disp  = (Fbm(nuv) - 0.5);
                float pulse = sin(_Time.y * _PulseSpeed) * 0.5 + 0.5;
                v.vertex.xyz += v.normal * disp * _CorruptionAmt * 0.04 * (0.7 + pulse * 0.3);

                o.pos         = UnityObjectToClipPos(v.vertex);
                o.uv          = v.uv;
                o.worldNormal = UnityObjectToWorldNormal(v.normal);
                o.worldPos    = mul(unity_ObjectToWorld, v.vertex).xyz;
                o.viewDir     = normalize(WorldSpaceViewDir(v.vertex));
                TRANSFER_SHADOW(o);
                return o;
            }

            fixed4 frag(v2f i) : SV_Target
            {
                float t = _Time.y * _NoiseSpeed;

                float2 uv1  = i.worldPos.xz * _NoiseScale * 0.5 + float2(sin(t*0.3)*0.1, t);
                float  n1   = Fbm(uv1);
                float2 warp = float2(Fbm(uv1+float2(1.7,9.2)), Fbm(uv1+float2(8.3,2.8)));
                float2 uv2  = i.worldPos.xz * (_NoiseScale*0.75) + warp*0.4 + float2(-t*0.5, t*0.8);
                float  n2   = Fbm(uv2);
                float  noise = lerp(n1, n2, 0.5);

                float pulse  = sin(_Time.y * _PulseSpeed) * 0.5 + 0.5;
                float pulse2 = sin(_Time.y * _PulseSpeed * 2.3 + 1.5) * 0.5 + 0.5;
                float flicker = 1.0 - _PulseAmount * (pulse*0.6 + pulse2*0.4);

                fixed4 baseTex    = tex2D(_MainTex, i.uv) * _Color;
                fixed3 darkBase   = pow(max(baseTex.rgb, 0.001), _DarknessPower) * (1.0 - _CorruptionAmt * 0.8);
                fixed3 corrupted  = lerp(darkBase, _EssenceColor.rgb, _CorruptionAmt * noise);

                fixed3 normal   = normalize(i.worldNormal);
                fixed3 lightDir = normalize(_WorldSpaceLightPos0.xyz);
                fixed  NdotL    = max(0, dot(normal, lightDir));
                fixed  shadow   = SHADOW_ATTENUATION(i);
                fixed3 ambient  = UNITY_LIGHTMODEL_AMBIENT.rgb * corrupted;
                fixed3 diffuse  = _LightColor0.rgb * corrupted * NdotL * shadow * 0.4;

                float rim      = 1.0 - saturate(dot(i.viewDir, normal));
                float rimMask  = pow(rim, _RimPower);
                fixed3 rimCol  = _RimColor.rgb * rimMask * _RimIntensity * flicker;

                float veins    = pow(abs(sin(noise * 12.0 + t)), 8.0);
                fixed3 veinCol = _RimColor.rgb * veins * 0.6 * flicker;

                fixed3 emission = fixed3(0,0,0);
                #ifdef _EMISSION_ON
                    emission += tex2D(_EmissionMap, i.uv).rgb * _EmissionColor.rgb;
                #endif
                emission += (rimCol + veinCol + _EssenceColor.rgb * noise * 0.3 * flicker)
                            * _EvilEmission;

                fixed3 final = ambient + diffuse + emission;
                return fixed4(final, 1);
            }
            ENDCG
        }

        Pass
        {
            Name "ForwardAdd"
            Tags { "LightMode"="ForwardAdd" }
            Blend One One
            ZWrite Off
            ZTest Always

            CGPROGRAM
            #pragma vertex   vert
            #pragma fragment fragAdd
            #pragma multi_compile_fwdadd_fullshadows
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "AutoLight.cginc"

            sampler2D _MainTex;
            fixed4  _Color;
            fixed4  _EssenceColor;
            float   _CorruptionAmt;
            float   _NoiseScale;
            float   _NoiseSpeed;
            float   _DarknessPower;

            float Hash(float2 p){ p=frac(p*float2(127.1,311.7)); p+=dot(p,p+19.19); return frac(p.x*p.y); }
            float ValueNoise(float2 p){ float2 i=floor(p),f=frac(p),u=f*f*(3-2*f); return lerp(lerp(Hash(i),Hash(i+float2(1,0)),u.x),lerp(Hash(i+float2(0,1)),Hash(i+float2(1,1)),u.x),u.y); }
            float Fbm(float2 p){ float v=0,a=0.5; float2x2 r=float2x2(1.6,1.2,-1.2,1.6); for(int i=0;i<4;i++){v+=a*ValueNoise(p);p=mul(r,p)*2.1;a*=0.45;} return v; }

            struct appdata { float4 vertex:POSITION; float3 normal:NORMAL; float2 uv:TEXCOORD0; };
            struct v2f { float4 pos:SV_POSITION; float2 uv:TEXCOORD0; float3 worldNormal:TEXCOORD1; float3 worldPos:TEXCOORD2; LIGHTING_COORDS(3,4) };

            v2f vert(appdata v)
            {
                v2f o;
                o.pos         = UnityObjectToClipPos(v.vertex);
                o.uv          = v.uv;
                o.worldNormal = UnityObjectToWorldNormal(v.normal);
                o.worldPos    = mul(unity_ObjectToWorld, v.vertex).xyz;
                TRANSFER_VERTEX_TO_FRAGMENT(o);
                return o;
            }

            fixed4 fragAdd(v2f i) : SV_Target
            {
                float  t     = _Time.y * _NoiseSpeed;
                float  noise = Fbm(i.worldPos.xz * _NoiseScale * 0.5 + float2(0, t));

                fixed3 baseTex  = tex2D(_MainTex, i.uv).rgb * _Color.rgb;
                fixed3 darkBase = pow(max(baseTex, 0.001), _DarknessPower) * (1.0 - _CorruptionAmt * 0.8);
                fixed3 albedo   = lerp(darkBase, _EssenceColor.rgb, _CorruptionAmt * noise);

                fixed3 normal   = normalize(i.worldNormal);
                fixed3 lightDir = normalize(_WorldSpaceLightPos0.xyz);
                fixed  NdotL    = max(0, dot(normal, lightDir));
                fixed  atten    = LIGHT_ATTENUATION(i);

                return fixed4(_LightColor0.rgb * albedo * NdotL * atten * 0.4, 0);
            }
            ENDCG
        }
    }
}