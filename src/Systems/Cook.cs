using Vintagestory.API.Common;

namespace Cook
{
    public class Cook : ModSystem
    {
        public override void Start(ICoreAPI api)
        {
            base.Start(api);

            api.RegisterBlockEntityClass("CookFirepit", typeof(BlockEntityCookFirepit));
        }
    }
}