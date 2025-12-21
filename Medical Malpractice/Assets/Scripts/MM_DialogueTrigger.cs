using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MM_DialogueTrigger : MonoBehaviour
{
    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;

    private void Start()
    {
        MM_DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
    }
}
