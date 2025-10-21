using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using WeBall.Content.SuperHardmode.Tiles.Biomes.Infection;

namespace WeBall.Content.SuperHardmode.Biomes
{
    public class InfectionBiome : ModBiome
    {
        public override int Music => MusicLoader.GetMusicSlot("WeBall/Assets/Music/InfectionBiome");

        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeHigh;

        public override string BestiaryIcon => "WeBall/Assets/Icons/Bestiary/InfectionBiome";
        public override string BackgroundPath => "WeBall/Assets/Backgrounds/InfectionBiome";
        public override Color? BackgroundColor => new Color(120, 70, 160);

        public override bool IsBiomeActive(Player player)
        {
            int infectionTileCount = 0;
            int startX = (int)(player.position.X / 16f) - 50;
            int endX = (int)(player.position.X / 16f) + 50;
            int startY = (int)(player.position.Y / 16f) - 30;
            int endY = (int)(player.position.Y / 16f) + 30;

            for (int x = startX; x < endX; x++)
            {
                for (int y = startY; y < endY; y++)
                {
                    if (WorldGen.InWorld(x, y, 10) && Main.tile[x, y].TileType == ModContent.TileType<InfectedStoneTile>())
                    {
                        infectionTileCount++;
                        if (infectionTileCount > 80)
                            return true;
                    }

                }
            }

            return false;
        }
    }
}