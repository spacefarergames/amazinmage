using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouWinACH : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Steamworks.SteamUserStats.SetAchievement("YouWin");
        Steamworks.SteamUserStats.StoreStats();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
