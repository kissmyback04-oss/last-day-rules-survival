Shader "Selected Effect --- Outline/Post Process/Halo" {
	Properties {
		_MainTex ("Main", 2D) = "black" {}
		_GlowObjectTex ("Glow Object", 2D) = "black" {}
		_GlowColor ("Glow Color", Vector) = (1,1,1,1)
		_GlowIntensity ("Glow Intensity", Float) = 3
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		sampler2D _MainTex;
		struct Input
		{
			float2 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}
		ENDCG
	}
}