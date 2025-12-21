using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
using Ink.Runtime;

public class MM_DialogManager : MonoBehaviour
{
    [Header("Ink Story")]
    [SerializeField] private TextAsset inkJson;

    private Story story;

    private bool dialogPlaying = false;

    private void Awake()
    {
        story = new Story(inkJson.text);
    }

    private void OnEnable()
    {
        MM_GameEventsManager._instance.dialogEvents.onEnterDialog += EnterDialog;
    }

    private void OnDisable()
    {
        MM_GameEventsManager._instance.dialogEvents.onEnterDialog -= EnterDialog;
    }

  /*  private void SubmitPressed(InputEventContext inputEventContext)
    {
        // if the context isn't dialogue, we never want to register input here
        if (!inputEventContext.Equals(InputEventContext.DIALOGUE))
        {
            return;
        }

        ContinueOrExitStory();
    }*/

    private void EnterDialog (string knotName)
    {
        if (dialogPlaying) 
        {
            return;
        }
        dialogPlaying = true;

        if (!knotName.Equals(""))
        {
            story.ChoosePathString(knotName);
        }
        else
        {
            Debug.LogWarning("Knot name was the empty string when entering dialogue.");
        }

        continueOrExitStory();
    }

    private void continueOrExitStory()
    {
        if (story.canContinue)
        {
            string dialogLine = story.Continue();

            Debug.Log(dialogLine);
        }
        else
        {
            exitDialog();
        }
    }

    private void exitDialog()
    {
        Debug.Log("Exiting Dialogue");
        dialogPlaying = false;

        story.ResetState();
    }
}
