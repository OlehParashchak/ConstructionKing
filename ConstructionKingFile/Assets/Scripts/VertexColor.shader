Shader "Scripts/VertexColor" {
    Properties {
        _MainTex ("Base (RGB)", 2D) = "white" {}
    }
    SubShader {
        pass {
            Lighting On
            ColorMaterial AmbientAndDiffuse
            SetTexture [_MainTex] {
                combine texture * primary DOUBLE
            }
        }
    }
}
