﻿// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Easy/TwoPassTransparent" {
	Properties {
		_Color ("Main Color", Color) = (1, 1, 1, 1)
		_MainTex ("Base (RGB)", 2D) = "white" { }
		_AddColor("Add Color", Color) = (0, 0, 0, 1)
	}

			CGINCLUDE
     
            #pragma vertex Vert
            #pragma fragment Frag
     
            #include "UnityCG.cginc"
      
            sampler2D 	_MainTex;           
            half4 		_Color;
            half4 		_AddColor;
            
            struct appdata {
				float4 vertex : POSITION;
				float2 txr1	: TEXCOORD0;
			};
         
            struct V2F         
            {         
                float4 pos:POSITION;    
                float2 txr1: TEXCOORD0;
            };
                        
            V2F Vert(appdata v)     
            {                 
                V2F output;
     
                output.pos = UnityObjectToClipPos(v.vertex);
                output.txr1 = v.txr1;
             
                return output;             
            }
             
         
            half4 Frag(V2F i):COLOR         
            {                 
                half4 o = tex2D(_MainTex, i.txr1);                                
                o.rgb = o.rgb*_AddColor.a + (o.rgb*_AddColor.rgb);  
                o *= _Color;
                                
                return o;
            }
         
            ENDCG

	SubShader {
		Tags { "Queue" = "Transparent" }

		Pass
		{
		
			Name "BASE"

			Cull Off
			Alphatest Greater 0
			ZWrite Off
			//ZTest Always
			Blend SrcAlpha OneMinusSrcAlpha 
			//ColorMask RGB
			

			Lighting Off

			CGPROGRAM
     
            #pragma vertex Vert
            #pragma fragment Frag
     

         
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
         
            ENDCG
		}
	}
	Fallback "Diffuse"
}