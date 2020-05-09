using System.ComponentModel;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace FasterPickaxes
{
    [Label("Faster Tools Config")]
    public class FastToolsConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        public static FastToolsConfig Instance;

        [Header("Speed")]
        [Label("Tool Speed")]
        [DefaultValue(1.25f)]
        [Range(0.5f, 10f)]
        public float PickaxeSpeed;
    }
}