using Ink.Runtime;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        MM_GameEventsManager._instance.dialogEvents.onEnterDialog += enterDialog;
    }

    private void OnDisable()
    {
        MM_GameEventsManager._instance.dialogEvents.onEnterDialog -= enterDialog;
    }

      private void submitPressed()
       {
           if (!dialogPlaying)
           {
               return;
           }

           continueOrExitStory();
       }

    private void enterDialog(string knotName)
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
