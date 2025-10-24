using Terraria.ModLoader.Config;
using System.ComponentModel;
using WeBall.Core.Systems;

namespace WeBall.Core.Configs
{
    public class SuperHardmodeConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [Label("Start off in SuperHardmode")]
        [Tooltip("Start Worlds in SuperHardmode! For those insane enough. Might not be beatable!")]
        [DefaultValue(false)]
        public bool StartInSuperHardmode;
    }
}