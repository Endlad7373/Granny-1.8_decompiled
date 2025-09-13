Shader "Vortex Game Studios/Filters/OLD TV Tube Effect" {
	Properties {
		_MainTex ("Base (RGB)", 2D) = "white" {}
		_ScreenHorizontal ("Screen Horizontal Orientation", Float) = 1
		_ScanLine ("ScanLine (RGB)", 2D) = "white" {}
		_ScanLineCount ("ScanLine Count (Resolution Size)", Float) = 100
		_ScanLineMin ("ScanLine Min", Float) = 0
		_ScanLineMax ("ScanLine Max", Float) = 1
		_MaskTex ("Mask (RGB)", 2D) = "white" {}
		_ReflexTex ("Reflex (RGB)", 2D) = "black" {}
		_ReflexMagnetude ("Reflex Magnetude", Range(0, 1)) = 0.5
		_Distortion ("Distortion", Range(-1, 1)) = 0.1
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			float4x4 unity_ObjectToWorld;
			float4x4 unity_MatrixVP;
			float4 _MainTex_ST;

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct Vertex_Stage_Output
			{
				float2 uv : TEXCOORD0;
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.uv = (input.uv.xy * _MainTex_ST.xy) + _MainTex_ST.zw;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			Texture2D<float4> _MainTex;
			SamplerState sampler_MainTex;

			struct Fragment_Stage_Input
			{
				float2 uv : TEXCOORD0;
			};

			float4 frag(Fragment_Stage_Input input) : SV_TARGET
			{
				return _MainTex.Sample(sampler_MainTex, input.uv.xy);
			}

			ENDHLSL
		}
	}
}