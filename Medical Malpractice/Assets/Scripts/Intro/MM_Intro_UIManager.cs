using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
using UnityEngine.Rendering;

public class MM_Intro_UIManager : MonoBehaviour
{
    [SerializeField]
    protected PlayerData data;

    public MM_UI_InputWindow iWindow;
    public MM_UI_Confirmation conf;
    public TMP_InputField input;
    public TMP_Text confText;

    void Awake()
    {
        input.characterLimit = 10;
        iWindow.showIF();
        conf.hideOpt();
        data.playerName = null;
    }

    public void clickSub()
    {
        iWindow.hideIF();
        conf.showOpt();
        data.playerName = input.text;
        confText.text = "Are you sure your name is " + data.playerName + "?";
    }

    public void clickNo()
    {
        conf.hideOpt();
        iWindow.showIF();
        input.text = string.Empty;
        data.playerName = null;
    }
}
