using SolutionsMod.Dusts.LightedDust;
using Terraria.ID;
using Terraria.ModLoader;

namespace SolutionsMod.Projectiles.Solutions.Filling.Block
{
    public class DirtSolution : BlockFillingSolution
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            dustType = ModContent.DustType<DirtDust>();
            blockID = TileID.Dirt;
        }
    }
}
