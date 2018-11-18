using Terraria;
using Terraria.ModLoader;

namespace FasterPickaxes
{
    class FastTools : GlobalItem
    {
        public override float UseTimeMultiplier(Item item, Player player) {
            if (item.pick > 0 || item.axe > 0 || item.hammer > 0) {
                if (item.damage > 0) {
                    return 1.25f;
                }
            }
            return 1f;
        }
    }
}
