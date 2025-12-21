
using UnityEngine;
using System;

public class MM_GameEventsManager : MonoBehaviour
{
    public static MM_GameEventsManager instance { get; private set; }

    public MM_DialogEvents dialogEvents;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Found more than one Game Events Manager in the scene.");
        }
        instance = this;

        dialogEvents = new MM_DialogEvents();
    }
}
