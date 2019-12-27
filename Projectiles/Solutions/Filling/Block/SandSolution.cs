using SolutionsMod.Dusts.LightedDust;
using Terraria.ID;
using Terraria.ModLoader;
namespace SolutionsMod.Projectiles.Solutions.Filling.Block
{
    public class SandSolution : BlockFillingSolution
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            dustType = ModContent.DustType<HoneyDust>();
            blockID = TileID.Sand;
        }
    }
}
