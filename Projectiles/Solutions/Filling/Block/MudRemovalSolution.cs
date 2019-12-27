using SolutionsMod.Dusts.LightedDust;
using Terraria.ID;
using Terraria.ModLoader;

namespace SolutionsMod.Projectiles.Solutions.Filling.Block
{
    public class MudRemovalSolution : BlockRemovalSolution
    {
        public static bool[] mudWalls = WallID.Sets.Factory.CreateBoolSet(new int[] { WallID.MudUnsafe});
        public override void SetDefaults()
        {
            base.SetDefaults();
            dustType = ModContent.DustType<DirtDust>();
            blockID = TileID.Mud;
            wallSet = mudWalls;
        }
    }
}
