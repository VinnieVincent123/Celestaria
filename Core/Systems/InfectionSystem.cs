using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.WorldBuilding;
using Terraria.ID;
using Terraria.GameContent.Generation;
using System.IO;
using Microsoft.Xna.Framework;
using WeBall.Content.SuperHardmode.Tiles.Ores;
using WeBall.Core.Systems;
using WeBall.Content.SuperHardmode.Tiles.Biomes.Infection;

namespace WeBall.Core.Systems
{
    public class InfectionSystem : ModSystem
    {
        private int spreadTimer;
        private const int SpreadInterval = 60 * 30;

        public override void PostUpdateWorld()
        {
            spreadTimer++;

            if (spreadTimer >= SpreadInterval)
            {
                spreadTimer = 0;
                SpreadInfection();
            }
        }

        private void SpreadInfection()
        {
            int dungeonX = (int)Main.dungeonX;
            int dungeonY = (int)Main.dungeonY;

            for (int i = 0; i < 100; i++)
            {
                int x = dungeonX + WorldGen.genRand.Next(-300, 300);
                int y = dungeonY + WorldGen.genRand.Next(-200, 200);

                if (!WorldGen.InWorld(x, y, 10))
                    continue;

                
                if (!Main.tile[x, y].HasTile)
                    continue;

                ushort type = Main.tile[x, y].TileType;

                if (type == TileID.Stone || type == TileID.Ebonstone || type == TileID.Pearlstone)
                {
                    Main.tile[x, y].TileType = (ushort)ModContent.TileType<InfectedStoneTile>();
                    WorldGen.SquareTileFrame(x, y);
                }        
                else if (type == TileID.Grass || type == TileID.JungleGrass || type == TileID.MushroomGrass)
                {
                    Main.tile[x, y].TileType = (ushort)ModContent.TileType<InfectedGrassTile>();
                    WorldGen.SquareTileFrame(x, y);
                }
                else if (type == TileID.Sand || type == TileID.Ebonsand || type == TileID.Pearlsand)
                {
                    Main.tile[x, y].TileType = (ushort)ModContent.TileType<InfectedSandTile>();
                    WorldGen.SquareTileFrame(x, y);
                }

                if (Main.rand.NextBool(50))
                    Dust.NewDust(new Vector2(x * 16, y * 16), 16, 16, DustID.CorruptGibs, 0f, 0f, 150, default, 0.8f);
            }
        }
    }
}
