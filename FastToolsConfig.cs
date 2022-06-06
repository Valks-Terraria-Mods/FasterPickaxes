namespace FasterPickaxes;

[Label("Faster Tools Config")]
public class FastToolsConfig : ModConfig
{
    public override ConfigScope Mode => ConfigScope.ServerSide;

    [Header("Speed")]
    [Label("Tool Speed")]
    [DefaultValue(1.25f)]
    [Range(1f, 30f)]
    public float PickaxeSpeed;

    public override void OnChanged()
    {
        FasterPickaxes.Speed = PickaxeSpeed;
    }
}
