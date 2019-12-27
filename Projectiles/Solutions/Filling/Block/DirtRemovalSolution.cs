using SolutionsMod.Dusts.LightedDust;
using Terraria.ID;
using Terraria.ModLoader;

namespace SolutionsMod.Projectiles.Solutions.Filling.Block
{
    public class DirtRemovalSolution : BlockRemovalSolution
    {
        public static bool[] dirtWalls = WallID.Sets.Factory.CreateBoolSet(new int[] { WallID.Dirt, WallID.DirtUnsafe, WallID.DirtUnsafe2, WallID.DirtUnsafe3, WallID.DirtUnsafe4 });
        public override void SetDefaults()
        {
            base.SetDefaults();
            dustType = ModContent.DustType<DirtDust>();
            blockID = TileID.Dirt;
            wallSet = dirtWalls;
        }
    }
}
