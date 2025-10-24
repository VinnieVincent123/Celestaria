using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;
using WeBall.Content.SuperHardmode.Biomes.SunPlains.Blocks;

namespace WeBall.Core.WorldGenC
{
    public static class SunPlainsConversion
    {
        public static void StartConversion()
        {
            for (int i = 0; i < Main.maxTilesX; i += 200)
            {
                int j = FindSurfaceY(i);
                if (IsForestTile(i, j))
                    ConvertArea(i, j, 80);
            }

            Main.NewText("The plains shimmer with divine light...", 255, 240, 120);
        }

        private static int FindSurfaceY(int x)
        {
            for (int y = 0; y < Main.maxTilesY; y++)
            {
                if (Main.tile[x, y].HasTile && Main.tileSolid[Main.tile[x, y].TileType])
                    return y - 1;
            }
            return Main.maxTilesY / 2;
        }

        private static bool IsForestTile(int x, int y)
        {
            ushort type = Main.tile[x, y].TileType;
            return type == TileID.Grass || type == TileID.Dirt || type == TileID.Trees;
        }

        private static void ConvertArea(int x, int y, int radius)
        {
            for (int i = -radius; i <= radius; i++)
            {
                int tx = x + i;
                int ty = y + i;
                if (!WorldGen.InWorld(tx, ty, 10)) continue;

                Tile tile = Main.tile[tx, ty];
                if (tile == null || !tile.HasTile) continue;

                if (tile.TileType == TileID.Grass)
                    tile.TileType = (ushort)ModContent.TileType<SunGrass>();
                else if (tile.TileType == TileID.Dirt)
                    tile.TileType = (ushort)ModContent.TileType<SunDirt>();

                if (tile.TileType == TileID.Trees)
                    WorldGen.KillTile(tx, ty);        
            }
        }
    }
}
