using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolutionsMod.Dusts.LightlessDust;
using SolutionsMod.Dusts.LightedDust;
using SolutionsMod.Projectiles.Solutions;
using Terraria;
using Terraria.ModLoader;

namespace SolutionsMod.Projectiles
{
    public class SolutionsGlobalProjectile : GlobalProjectile
    {

        public static Dictionary<int, int> dustToLightless;

        static SolutionsGlobalProjectile()
        {
            Mod mod = ModLoader.GetMod("SolutionsMod");
            dustToLightless = new Dictionary<int, int>();
            dustToLightless.Add(110, ModContent.DustType<BaseLightlessDust>());
            dustToLightless.Add(111, ModContent.DustType<LightlessBlueDust>());
            dustToLightless.Add(112, ModContent.DustType<LightlessPurpleDust>());
            dustToLightless.Add(113, ModContent.DustType<LightlessDeepBlueDust>());
            dustToLightless.Add(114, ModContent.DustType<LightlessRedDust>());

            dustToLightless.Add(ModContent.DustType<ClayDust>(), ModContent.DustType<LightlessClayDust>());
            dustToLightless.Add(ModContent.DustType<DirtDust>(), ModContent.DustType<LightlessDirtDust>());
            dustToLightless.Add(ModContent.DustType<GraniteDust>(), ModContent.DustType<LightlessGraniteDust>());
            dustToLightless.Add(ModContent.DustType<HoneyDust>(), ModContent.DustType<LightlessHoneyDust>());
            dustToLightless.Add(ModContent.DustType<IceRemoveDust>(), ModContent.DustType<LightlessIceRemoveDust>());
            dustToLightless.Add(ModContent.DustType<IceSpreadDust>(), ModContent.DustType<LightlessIceSpreadDust>());
            dustToLightless.Add(ModContent.DustType<JungleDust>(), ModContent.DustType<LightlessJungleDust>());
            dustToLightless.Add(ModContent.DustType<LavaDust>(), ModContent.DustType<LightlessLavaDust>());
            dustToLightless.Add(ModContent.DustType<MarbleDust>(), ModContent.DustType<LightlessMarbleDust>());
            dustToLightless.Add(ModContent.DustType<MineralDust>(), ModContent.DustType<LightlessMineralDust>());
            dustToLightless.Add(ModContent.DustType<RockDust>(), ModContent.DustType<LightlessRockDust>());
            dustToLightless.Add(ModContent.DustType<WaterDust>(), ModContent.DustType<LightlessWaterDust>());

        }

        public override bool PreAI(Projectile projectile)
        {
            if (projectile.modProjectile != null && projectile.modProjectile is BaseSolution)
            {
                BaseSolution bs = projectile.modProjectile as BaseSolution;
                if (bs.toChange)
                {
                    SolutionsPlayer p = Main.player[projectile.owner].GetModPlayer<SolutionsPlayer>();
                    if (p.solTimesFour)
                    {
                        bs.maxTime *= 4;
                    }
                    if (p.solTimesTwo)
                    {
                        bs.maxTime *= 2;
                    }
                    if (p.solTimesOneThird)
                    {
                        bs.maxTime /= 3;
                    }
                    if (p.solTimesOneFifth)
                    {
                        bs.maxTime /= 5;
                    }
                    projectile.timeLeft = bs.maxTime;

                    if (p.solRadiusDouble)
                    {
                        bs.radius *= 2;
                    }
                    if (p.solRadiusHalf)
                    {
                        bs.radius /= 2;
                    }

                    if (p.lightless)
                    {
                        bs.dustType = dustToLightless[bs.dustType];
                    }
                    bs.toChange = false;
                }
            }
            return base.PreAI(projectile);
        }

        public override void SetDefaults(Projectile projectile)
        {
            if (projectile.modProjectile != null && projectile.modProjectile is BaseSolution)
            {
                BaseSolution bs = projectile.modProjectile as BaseSolution;
                bs.toChange = true;
            }
        }
    }
}
