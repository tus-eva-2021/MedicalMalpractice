using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

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

    public void clickYes()
    {
        if (data.playerName.Length > 0)
        {
            conf.hideOpt();
            iWindow.showIF();
            Debug.Log("Starting Game...");
            SceneManager.LoadScene("Main_Medical_Malpractice");
        }

        if (data.playerName.Length <= 0)
        {
            clickNo();
        }
    }
}
