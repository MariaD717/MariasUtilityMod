using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public class MyPlayer : ModPlayer
{
    public override void OnEnterWorld()
    {
        Player.QuickSpawnItem(
             Player.GetSource_GiftOrReward(),
             ItemID.Meowmere,
             1
         );
        Player.QuickSpawnItem(
           Player.GetSource_GiftOrReward(),
           ItemID.SnowBlock,
           20
       );
        Player.QuickSpawnItem(
          Player.GetSource_GiftOrReward(),
          ItemID.IronBar,
          5
      );
        Player.QuickSpawnItem(
          Player.GetSource_GiftOrReward(),
          ItemID.FallenStar,
          20
      );
        Player.QuickSpawnItem(
           Player.GetSource_GiftOrReward(),
           ItemID.MythrilAnvil,
           1
       );
        Player.QuickSpawnItem(
          Player.GetSource_GiftOrReward(),
          ItemID.OrichalcumAnvil,
          1
      );
        Player.QuickSpawnItem(
          Player.GetSource_GiftOrReward(),
          ItemID.PinkGel,
          20
      );
        Player.QuickSpawnItem(
          Player.GetSource_GiftOrReward(),
          ItemID.StoneBlock,
          10
      );
    }
}
