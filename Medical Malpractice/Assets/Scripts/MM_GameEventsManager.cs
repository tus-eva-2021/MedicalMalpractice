using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MM_GameEventsManager : MonoBehaviour
{
    public static MM_GameEventsManager _instance { get; private set; }

    public MM_DialogEvents dialogEvents;
    public MM_InputManager inputEvents;

    private void Awake()
    {
        if (_instance != null)
        {
            Debug.LogError("Found more than one Game Events Manager in the scene.");
        }
        _instance = this;

        inputEvents = new MM_InputManager();
        dialogEvents = new MM_DialogEvents();
    }
}
