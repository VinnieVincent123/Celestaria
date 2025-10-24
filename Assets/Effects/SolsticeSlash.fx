sampler2D : register(s0);

float2 uCenter;
float uTime;
float3 uColor;

float4 PixelShaderFunction(float2 uv : TEXCOORD0) : COLOR0
{
    float2 diff = uv - uCenter;
    float dist = length(diff);
    float angle = atan2(diff.y, diff.x);

    float slash = smoothstep(0.25, 0.20, abs(angle - sin(uTime) * 1.2));
    float pulse = sin(uTime * 4 + dist * 25) * 0.5 + 0.5;
    float falloff = smoothstep(0.35, 0.0, dist);

    float strength = slash * pulse * falloff;
    return float4(uColor * strength, strength);
}

technique Technique1
{
    pass P0
    {
        PixelShader = compile ps_2_0 PixelShaderFunction();
    }
}