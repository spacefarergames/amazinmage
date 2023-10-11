using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefJSONInit : MonoBehaviour
{
   
    
    



    // Start is called before the first frame update
    void Start()
    {
        // build your config

        var config = new FBPPConfig()
        {
            SaveFileName = "amazinMage_Seed_save.dat",
            AutoSaveData = true,
            ScrambleSaveData = false,
            EncryptionSecret = "my-secret",
            SaveFilePath = Application.persistentDataPath
    };
        // pass it to FBPP
        FBPP.Start(config);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
