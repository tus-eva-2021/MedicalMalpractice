using System;

public class MM_DialogEvents
{
    public event Action<string> onEnterDialog;
    public void EnterDialog(string knotName)
    {
        if (onEnterDialog != null)
        {
            onEnterDialog(knotName);
        }
    }
}
