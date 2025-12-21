using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MM_TriggerDialog : MonoBehaviour
{
    [Header("Dialogue (optional)")]
    [SerializeField] private string dialogKnotName;

    public void triggerDialog()
    {
        if (!dialogKnotName.Equals(""))
        {
            MM_GameEventsManager._instance.dialogEvents.EnterDialog(dialogKnotName);
        }
    }
}
