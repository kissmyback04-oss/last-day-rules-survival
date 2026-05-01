Shader "Shader Forge/xuanzekuang_01" {
	Properties {
		_bianyuankuandu_01 ("bianyuankuandu_01", Range(0, 2)) = 1
		_node_4648 ("node_4648", Vector) = (0.5,0.5,0.5,1)
		_bianyuanliangdu_01 ("bianyuanliangdu_01", Float) = 1
		_qixiankuandu_01 ("qixiankuandu_01", Range(-1, 1)) = 0.46
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