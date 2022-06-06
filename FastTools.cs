namespace FasterPickaxes;

public class FastTools : GlobalItem
{
    public override float UseSpeedMultiplier(Item item, Player player)
    {
        if (item.pick > 0 || item.axe > 0 || item.hammer > 0)
            if (item.damage > 0)
                return FasterPickaxes.Speed;

        return 1f;
    }
}
