﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolutionsMod.Dusts.LightedDust;
using Terraria.ID;
using Terraria.ModLoader;

namespace SolutionsMod.Projectiles.Solutions.GrassSpread
{
    public class JungleGrassSpreadSolution : BaseGrassSpreadSolution
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            dustType = ModContent.DustType<JungleDust>();
            dirtID = TileID.Mud;
            grassID = TileID.JungleGrass;
            wallSet = null;
        }
    }
}
