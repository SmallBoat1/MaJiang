// Upgrade NOTE: replaced '_World2Object' with 'unity_WorldToObject'

// Upgrade NOTE: replaced '_World2Object' with 'unity_WorldToObject'
// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Custom/DiffuseVertexLevelMat" {
	Properties {
		_Deffuse ("deffuse", Color) = (1,1,1,1)
	}

	SubShader{
		Tags{
				"LightMode" = "ForwardBase"
			}
		Pass{
			CGPROGRAM
				// 定义顶点着色器
				#pragma vertex vert 
				// // 定义片元着色器
				#pragma fragment frag
				// 引用内置光照文件
				#include "Lighting.cginc"

				fixed4 _Deffuse;

				struct a2v
				{
					float4 vertex : POSITION;
					float3 normal : NORMAL;
				};

			    struct v2f {
					float4 pos: SV_POSITION;
					// float3 color:COLOR;
					float3 worldNormal:TEXCOORD0;
				};
				
				v2f vert (a2v v)
				{
					v2f o;
					o.pos = UnityObjectToClipPos(v.vertex);
					o.worldNormal = mul(v.normal,(float3x3)unity_WorldToObject);
					// fixed3 ambient = UNITY_LIGHTMODEL_AMBIENT.xyz;
					// fixed3 worldNormal = mul(v.normal,(float3x3)unity_WorldToObject);
					// fixed3 worldLight = (_WorldSpaceLightPos0.xyz);
					// fixed3 deffuse = _LightColor0.rgb * _Deffuse.rgb * saturate(dot(worldNormal,worldLight));
					// o.color = ambient + deffuse;
					return o;	
				}

				fixed4 frag(v2f i) : SV_Target
				{
					fixed3 ambient = UNITY_LIGHTMODEL_AMBIENT.xyz;
					fixed3 worldNormal = normalize(i.worldNormal);
					fixed3 worldLightDir = normalize(_WorldSpaceLightPos0.xyz);
					fixed3 diffuse = _LightColor0.rgb * _Deffuse.rgb * saturate(dot(worldNormal,worldLightDir));
					fixed3 color = diffuse + ambient;

					return fixed4(color,1.0);
					// return fixed4(i.color,1.0);
					// return _Deffuse;
				}

			ENDCG
		}
	}
	FallBack "Diffuse"
}
