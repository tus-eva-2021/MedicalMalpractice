using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
using UnityEngine.Rendering;

public class MM_Intro_UIManager : MonoBehaviour
{
    public MM_UI_InputWindow iWindow;
    public MM_UI_Confirmation conf;
    public TMP_InputField input;
    public string playerName;
    public TMP_Text confText;
    void Awake()
    {
        iWindow.showIF();
        conf.hideOpt();
        playerName = null;
    }

    public void clickSub()
    {
        iWindow.hideIF();
        conf.showOpt();
        playerName = input.text;
        confText.text = "Are you sure your name is " + playerName + "?";
    }

    public void clickNo()
    {
        conf.hideOpt();
        iWindow.showIF();
        input.text = string.Empty;
        playerName = null;
    }
}
