using UnityEngine;

public class MM_GameEventsManager : MonoBehaviour
{
    public static MM_GameEventsManager _instance { get; private set; }

    public MM_DialogEvents dialogEvents;

    private void Awake()
    {
        if (_instance != null)
        {
            Debug.LogError("Found more than one Game Events Manager in the scene.");
        }
        _instance = this;

        dialogEvents = new MM_DialogEvents();
    }
}
