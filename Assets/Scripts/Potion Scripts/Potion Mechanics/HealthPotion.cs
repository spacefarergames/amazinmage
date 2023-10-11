using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : Potion
{
    public override void UsePotion()
    {
        Player.Instance.Health += 10;
        Steamworks.SteamUserStats.SetAchievement("HealthPotion");
        Steamworks.SteamUserStats.StoreStats();
    }
}
