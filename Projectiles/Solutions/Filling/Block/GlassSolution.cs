using SolutionsMod.Dusts.LightedDust;
using Terraria.ID;
using Terraria.ModLoader;

namespace SolutionsMod.Projectiles.Solutions.Filling.Block
{
    public class GlassSolution : BlockFillingSolution
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            dustType = ModContent.DustType<IceSpreadDust>();
            blockID = TileID.Glass;
        }
    }
}
