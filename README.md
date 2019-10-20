All pickaxes, axes and hammers operate 25% faster as shown below.

```cs
public override float UseTimeMultiplier(Item item, Player player) {
 if (item.pick > 0 || item.axe > 0 || item.hammer > 0) {
  if (item.damage > 0) {
   return 1.25 f;
  }
 }
 return 1 f;
}
```
