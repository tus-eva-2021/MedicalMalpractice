using UnityEngine;

public class MM_DialogueTrigger : MonoBehaviour
{
    [SerializeField]
    protected PlayerData data;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;

    private MM_DialogueManager dialogueManager;

    private void Start()
    {
        string name = data.playerName;
        Ink.Runtime.Object obj = new Ink.Runtime.StringValue(name);
        MM_DialogueManager.GetInstance().SetVariableState("player_name", obj);

        MM_DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
    }
}
