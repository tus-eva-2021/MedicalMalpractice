using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MM_InputManager
{
    public MM_InputEventContext inputEventContext { get; private set; } = MM_InputEventContext.DEFAULT;

    public void ChangeInputEventContext(MM_InputEventContext newContext)
    {
        this.inputEventContext = newContext;
    }

    public event Action<MM_InputEventContext> onSubmitPressed;
    public void SubmitPressed()
    {
        if (onSubmitPressed != null)
        {
            onSubmitPressed(this.inputEventContext);
        }
    }
}
