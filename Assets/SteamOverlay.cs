using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Steamworks;
using System.Security.Cryptography;

public class SteamOverlay : MonoBehaviour
{
    protected Callback<GameOverlayActivated_t> overlayIsOn;
    Vector3 myVector;
    // Start is called before the first frame update
    void Start()
    {
        if (!SteamManager.Initialized)
        {
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        overlayIsOn = Callback<GameOverlayActivated_t>.Create(PauseGameIfSteamOverlayOn);
      

    }

    void PauseGameIfSteamOverlayOn(GameOverlayActivated_t callback)
    {

        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(true);
        }
        Time.timeScale = 0f;
        PauseMenu.GameIsPaused = true;





    }
    

}
