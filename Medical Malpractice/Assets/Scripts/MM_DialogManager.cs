using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MM_DialogManager : MonoBehaviour
{
    public List<TMP_Text> kentLines = new List<TMP_Text>();
    public int clickCount;

    void Start()
    {
        clickCount = 0;
        for (int i = 0; i < kentLines.Count; i++)
        {
            kentLines[i].enabled = false;
        }

        kentLines[clickCount].enabled = true;
    }

   
    void Update()
    {
        
    }

    public void clickNext()
    {
        kentLines[clickCount].enabled = false;
        clickCount = clickCount + 1;
        kentLines[clickCount].enabled = true;
    }
}
