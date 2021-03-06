﻿// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "NewOutLine" {
	Properties {
		_Color ("Main Color", Color) = (1, 1, 1, 1)
		_OutlineColor ("Outline Color", Color) = (1,0,0,1)
		_Outline ("Outline width", Range (0.0, 0.03)) = .003
		_MainTex ("Base (RGB)", 2D) = "white" { }
	}
	CGINCLUDE
		#include "UnityCG.cginc"
		struct appdata {
			float4 vertex : POSITION;
			float3 normal : NORMAL;
			float2 txr1:TEXCOORD0;
		};
		struct v2f {
			float4 pos : POSITION;
			float2 txr1:TEXCOORD0;
			float4 color : COLOR;
		};
		uniform float _Outline;
		uniform float4 _OutlineColor;
		v2f vert(appdata v) {
			v2f o;
			o.pos = UnityObjectToClipPos(v.vertex);
			float3 norm   = mul ((float3x3)UNITY_MATRIX_IT_MV, v.normal);
			float2 offset = TransformViewToProjection(norm.xy);
			o.pos.xy += offset * o.pos.z * _Outline;
			o.color = _OutlineColor;
			o.txr1 = v.txr1;
			return o;
		}
		
	ENDCG



	SubShader {
		Tags { "Queue" = "Transparent" }
		Pass {
			Tags { "LightMode" = "Always" }
			Cull Off
			ZWrite Off
			//ZTest Always
			Alphatest Greater 0
			//ColorMask RGB // alpha not used
			Blend SrcAlpha OneMinusSrcAlpha // Normal

			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			sampler2D _MainTex;
			half4 _Color;			
			
			half4 frag(v2f i) :COLOR {
				half4 o = tex2D(_MainTex, i.txr1);            
				o.rgb = i.color.rgb;
				o.a *= _Color.a;
				return o;
			}
			ENDCG
		}



		Pass
		{
			Name "BASE"
			ZWrite On
			ZTest LEqual
			Blend SrcAlpha OneMinusSrcAlpha

			Lighting Off

			CGPROGRAM
     
   
            #pragma vertex Vert
 
            #pragma fragment Frag
     
            #include "UnityCG.cginc"
     
 
            sampler2D _MainTex;
            half4 _Color;
         
            struct V2F
         
            {
         
                float4 pos:POSITION;
     
                float2 txr1:TEXCOORD0;
         
            };
               
         
            V2F Vert(appdata_base v)
     
            {
                 
                V2F output;
     
                output.pos = UnityObjectToClipPos(v.vertex);
     
                output.txr1 = v.texcoord;
             
                return output;
             
            }
             
         
            half4 Frag(V2F i):COLOR
         
            {
                 
                half4 o = tex2D(_MainTex,i.txr1);                
                o.a *= _Color.a;
                return o;
     			//o.a = _Color.a;
     			//return o;
            }
 
         
            ENDCG
		}
	}
	Fallback "Diffuse"
}