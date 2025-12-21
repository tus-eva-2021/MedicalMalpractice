using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MM_DialogManager : MonoBehaviour
{
    private bool dialogPlaying = false;

    private void OnEnable()
    {
        MM_GameEventsManager.instance.dialogEvents.onEnterDialog += EnterDialog;
    }

   
    private void OnDisable()
    {
        MM_GameEventsManager.instance.dialogEvents.onEnterDialog -= EnterDialog;
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
