﻿using System;
using SolutionsMod.Dusts.LightedDust;
using Terraria;
using Terraria.ModLoader;

namespace SolutionsMod.Projectiles.Solutions.BiomeChange
{
    public class MarbleSolution: BaseSolution
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            //projectile.name = "Marble Spray";
            maxTime = 134;
            dustType = ModContent.DustType<MarbleDust>();
        }

        public override void Convert(int i, int j, int size = 4)
        {
            for (int k = i - size; k <= i + size; k++)
            {
                for (int l = j - size; l <= j + size; l++)
                {
                    if (WorldGen.InWorld(k, l, 1) && Math.Abs(k - i) + Math.Abs(l - j) < Math.Sqrt(size * size + size * size))
                    {
                        int type = (int)Main.tile[k, l].type;
                        int wall = (int)Main.tile[k, l].wall;

                        if (wall == 3 || wall == 28 || (wall > 53 && wall < 60) || wall == 61 || wall == 83 || wall == 180)
                        {
                            Main.tile[k, l].wall = 178;
                            WorldGen.SquareWallFrame(k, l, true);
                            NetMessage.SendTileSquare(-1, k, l, 1);
                        }

                        if (type == 1 || type == 25 || type == 117 || type == 203 || type == 368)
                        {
                            Main.tile[k, l].type = 367;
                            WorldGen.SquareTileFrame(k, l, true);
                            NetMessage.SendTileSquare(-1, k, l, 1);
                        }
                    }
                }
            }
        }
    }
}
