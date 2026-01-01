using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MM_UI_Confirmation : MonoBehaviour
{
    public void showOpt()
    {
        gameObject.SetActive(true);
    }

    public void hideOpt()
    {
        gameObject.SetActive(false);
    }
}
