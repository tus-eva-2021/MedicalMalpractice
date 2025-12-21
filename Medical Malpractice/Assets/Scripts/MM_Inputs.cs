using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]

public class MM_Inputs : MonoBehaviour
{
    public void SubmitPressed(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            MM_GameEventsManager._instance.inputEvents.SubmitPressed();
        }
    }
}
