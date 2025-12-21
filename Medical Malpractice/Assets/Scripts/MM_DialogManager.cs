using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class MM_DialogManager : MonoBehaviour
{
    
    private bool dialogPlaying = false;

    private void OnEnable()
    {
        MM_GameEventsManager._instance.dialogEvents.onEnterDialog += EnterDialog;
    }

   
    private void OnDisable()
    {
        MM_GameEventsManager._instance.dialogEvents.onEnterDialog -= EnterDialog;
    }

    private void EnterDialog (string knotName)
    {
        if (dialogPlaying) 
        {
            return;
        }
        dialogPlaying = true;
    }
}
