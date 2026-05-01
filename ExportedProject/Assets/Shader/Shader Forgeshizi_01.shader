Shader "Shader Forge/shizi_01" {
	Properties {
		_node_7318 ("node_7318", 2D) = "white" {}
		_node_2646 ("node_2646", 2D) = "black" {}
		_liangdu ("liangdu", Float) = 2
		_yanse ("yanse", Vector) = (1,0.8655173,0.4264706,1)
		[HideInInspector] _Cutoff ("Alpha cutoff", Range(0, 1)) = 0.5
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		struct Input
		{
			float2 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			o.Albedo = 1;
		}
		ENDCG
	}
	//CustomEditor "ShaderForgeMaterialInspector"
}