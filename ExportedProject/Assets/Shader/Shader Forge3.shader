Shader "Shader Forge/3" {
	Properties {
		_node_1324 ("node_1324", 2D) = "white" {}
		_node_5059 ("node_5059", Vector) = (0.5,0.5,0.5,1)
		_node_492 ("node_492", Range(0, 3)) = 2
		_node_1605 ("node_1605", 2D) = "white" {}
		_node_4307 ("node_4307", 2D) = "white" {}
		_node_7917 ("node_7917", 2D) = "white" {}
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