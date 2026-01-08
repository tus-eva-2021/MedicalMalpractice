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

    [SerializeField] public Image fadeIMG;
    int fadeDuration = 1;

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
            Debug.Log("Starting Game...");
            StartCoroutine(FadeToBlack());
        }

        if (data.playerName.Length <= 0)
        {
            clickNo();
        }
    }

    IEnumerator FadeToBlack()
    {
        Color initialColour = fadeIMG.color;
        Color targetColour = new Color(initialColour.r, initialColour.g, initialColour.b, 1f);
        float elapsedTime = 0f;

        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            fadeIMG.color = Color.Lerp(initialColour, targetColour, elapsedTime / fadeDuration);
            yield return null;
        }

        SceneManager.LoadScene("Main_Medical_Malpractice");
    }
}
