using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MM_UI_InputWindow : MonoBehaviour
{
   public void showIF()
    {
        gameObject.SetActive(true);
    }

    public void hideIF()
    {
        gameObject.SetActive(false);
    }
}
