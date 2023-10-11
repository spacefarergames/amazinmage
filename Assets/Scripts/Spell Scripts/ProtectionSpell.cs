using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtectionSpell : Spell
{
    public float protectionDur = 10f;

    public override void TriggerSpellEffect(GameObject other)
    {
        Player.Instance.StartCoroutine(Player.Instance.ProtectionBubble(protectionDur));
        Steamworks.SteamUserStats.SetAchievement("Bubble");
        Steamworks.SteamUserStats.StoreStats();
        Destroy(gameObject);
    }

    protected override void Start()
    {
        TriggerSpellEffect(null);
    }
}
