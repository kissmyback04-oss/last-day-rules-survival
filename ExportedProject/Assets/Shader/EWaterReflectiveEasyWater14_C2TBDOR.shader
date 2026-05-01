Shader "EWater/Reflective/EasyWater14_C2TBDOR" {
	Properties {
		_Color ("_Color", Vector) = (1,1,1,1)
		_Texture1 ("_Texture1", 2D) = "black" {}
		_BumpMap1 ("_BumpMap1", 2D) = "black" {}
		_Texture2 ("_Texture2", 2D) = "black" {}
		_BumpMap2 ("_BumpMap2", 2D) = "black" {}
		_MainTexSpeed ("_MainTexSpeed", Float) = 0
		_Bump1Speed ("_Bump1Speed", Float) = 0
		_Texture2Speed ("_Texture2Speed", Float) = 0
		_Bump2Speed ("_Bump2Speed", Float) = 0
		_DistortionMap ("_DistortionMap", 2D) = "black" {}
		_DistortionSpeed ("_DistortionSpeed", Float) = 0
		_DistortionPower ("_DistortionPower", Range(0, 0.02)) = 0
		_Specular ("_Specular", Range(0, 7)) = 1
		_Gloss ("_Gloss", Range(0.3, 2)) = 0.3
		_Opacity ("_Opacity", Range(-0.2, 1)) = 0
		_Reflection ("_Reflection", 2D) = "black" {}
		_ReflectPower ("_ReflectPower", Range(0, 0.8)) = 0
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		fixed4 _Color;
		struct Input
		{
			float2 uv_MainTex;
		};
		
		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			o.Albedo = _Color.rgb;
			o.Alpha = _Color.a;
		}
		ENDCG
	}
	Fallback "Diffuse"
}