using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[PostProcess(typeof(SobelRenderer), PostProcessEvent.BeforeStack, "SobelProcess")]
public class SobelProcess : PostProcessEffectSettings
{
    public ColorParameter darkColour = new ColorParameter { value = Color.black };
    public ColorParameter lightColour = new ColorParameter { value = Color.white };
}

public sealed class SobelRenderer : PostProcessEffectRenderer<SobelProcess>
{
    public override void Render(PostProcessRenderContext context)
    {
        var sheet = context.propertySheets.Get(Shader.Find("PostProcessing/SobelOutline"));
        sheet.properties.SetColor("_DarkColor", settings.darkColour);
        sheet.properties.SetColor("_LightColor", settings.lightColour);

        context.command.BlitFullscreenTriangle(context.source, context.destination, sheet, 0);
    }
}
