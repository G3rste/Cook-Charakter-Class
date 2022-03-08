using Vintagestory.API.Common;
using Vintagestory.GameContent;

namespace Cook
{
    public class BlockEntityCookFirepit : BlockEntityFirepit
    {
        public float cookingTimePlayerStat = 1;

        public override float maxCookingTime()
        {
            return base.maxCookingTime() * cookingTimePlayerStat;
        }
        public override bool OnPlayerRightClick(IPlayer byPlayer, BlockSelection blockSel)
        {
            cookingTimePlayerStat = byPlayer.Entity.Stats.GetBlended("cookingTime");
            // Debug Output: uncomment to see the current
            // Api.Logger.Debug("New cooking time multiplier is {0}", cookingTimePlayerStat);
            return base.OnPlayerRightClick(byPlayer, blockSel);
        }
    }
}