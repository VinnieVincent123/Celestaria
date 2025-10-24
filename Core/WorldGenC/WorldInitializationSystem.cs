using Terraria;
using Terraria.ModLoader;
using WeBall.Core.Configs;
using WeBall.Core.Systems;

namespace WeBall.Core.WorldGenC
{
    public class WorldInitializationSystem : ModSystem
    {
        public override void PostWorldGen()
        {
                var config = ModContent.GetInstance<SuperHardmodeConfig>();

                if (config.StartInSuperHardmode)
                {
                    Main.NewText("This world was born in divine radiance!", 255, 230, 120);

                    Main.hardMode = true;
                    SuperHardmodeSystem.superHardmode = true;
                    SunPlainsConversion.StartConversion();
                } 
            }
        }
    }
