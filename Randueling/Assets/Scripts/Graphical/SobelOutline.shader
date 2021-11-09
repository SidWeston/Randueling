Shader "PostProcessing/SobelOutline"
{
    
    HLSLINCLUDE
    #include "Packages/com.unity.postprocessing/PostProcessing/Shaders/StdLib.hlsl"
    TEXTURE2D_SAMPLER2D(_CameraDepthTexture, sampler_CameraDepthTexture);
    float4 _DarkColor;
    float4 _LightColor;
    
    float SobelDepth(float ldc, float ldl, float ldr, float ldu, float ldd)
    {
        return abs(ldl - ldc) +
            abs(ldr - ldc) +
            abs(ldu - ldc) +
            abs(ldd - ldc);
    }
    
    float SobelSampleDepth(Texture2D t, SamplerState s, float2 uv, float3 offset)
    {
        float pixelCenter = LinearEyeDepth(t.Sample(s, uv).r);
        float pixelLeft = LinearEyeDepth(t.Sample(s, uv - offset.xz).r);
        float pixelRight = LinearEyeDepth(t.Sample(s, uv + offset.xz).r);
        float pixelUp = LinearEyeDepth(t.Sample(s, uv + offset.zy).r);
        float pixelDown = LinearEyeDepth(t.Sample(s, uv - offset.zy).r);

        //Used to artificially "band" the results of the depth buffer, find better solution later!!
        return sqrt(SobelDepth(round(pixelCenter * 100) / 100, round(pixelLeft * 100) / 100, round(pixelRight * 100) / 100, round(pixelUp * 100) / 100, round(pixelDown * 100) / 100));
    }

    float4 FragMain(VaryingsDefault i) : SV_Target
    {
        float3 offset = float3((1.0 / _ScreenParams.x), (1.0 / _ScreenParams.y), 0.0) * 0.5;
        float pixelValue = SobelSampleDepth(_CameraDepthTexture, sampler_CameraDepthTexture, i.texcoord.xy, offset).r;
        //Used to set the black and white to the two colours set in editor
        float3 finalColor = lerp(_DarkColor, _LightColor, pixelValue);
        return float4(finalColor,1.0);
    }
        ENDHLSL

        
        
        
        
        SubShader
    {
        Cull Off ZWrite Off ZTest Always

            Pass
        {
            HLSLPROGRAM
                #pragma vertex VertDefault
                #pragma fragment FragMain
            ENDHLSL
        }
    }
}