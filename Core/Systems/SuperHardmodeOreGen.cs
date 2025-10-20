using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.WorldBuilding;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using WeBall.Content.SuperHardmode.Tiles.Ores;

namespace WeBall.Core.Systems
{
    public class SuperHardmodeOreGen : ModSystem
    {
        public static void GenerateSuperOres()
        {
            if (!SuperHardmodeSystem.superHardmode)
                return;

            int worldTiles = Main.maxTilesX * Main.maxTilesY;
            int vibraniumAmount = (int)(worldTiles * 0.00008);
            int uruAmount = (int)(worldTiles * 0.00005);
            int beskarAmount = (int)(worldTiles * 0.00003);

            GenerateOre(ModContent.TileType<VibraniumOreTile>(), vibraniumAmount, Main.rockLayer, Main.maxTilesY - 200);
            GenerateOre(ModContent.TileType<UruOreTile>(), uruAmount, Main.rockLayer, Main.maxTilesY - 300);
            GenerateOre(ModContent.TileType<BeskarOreTile>(), beskarAmount, Main.rockLayer + 150, Main.maxTilesY - 100);

        }

        private static void GenerateOre(int tileType, int count, double minY, double maxY)
        {
            for (int i = 0; i < count; i++)
            {
                int x = WorldGen.genRand.Next(100, Main.maxTilesX - 100);
                int y = WorldGen.genRand.Next((int)Main.worldSurface, Main.maxTilesY - 200);
                WorldGen.OreRunner(x, y, WorldGen.genRand.Next(3, 7), WorldGen.genRand.Next(3, 7), (ushort)tileType);
            }
        }
    }
}
