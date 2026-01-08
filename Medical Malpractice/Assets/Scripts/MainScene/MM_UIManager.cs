using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class MM_UIManager : MonoBehaviour
{
    public MM_DialogueManager dialogueManager;

    [SerializeField] public Image fadeIMG;
    int fadeDuration = 1;

    public bool fadeON = false;

    void FixedUpdate()
    {
        if (dialogueManager.fadeString == "true" && fadeON == false)
        {
            StartCoroutine(FadeToScreen());
        }

        if (dialogueManager.fadeString == "false" && fadeON == true)
        {
            StartCoroutine(FadeToBlack());
        }
    }

    IEnumerator FadeToBlack()
    {
        fadeON = false;
        Debug.Log("Fade to Black");

        Color initialColour = fadeIMG.color;
        Color targetColour = new Color(initialColour.r, initialColour.g, initialColour.b, 1f);
        float elapsedTime = 0f;
        yield return new WaitForSeconds(3f);

        while (elapsedTime < fadeDuration)
        { 
            
            elapsedTime += Time.deltaTime;
            fadeIMG.color = Color.Lerp(initialColour, targetColour, elapsedTime / fadeDuration);
            yield return null;
        }
       
        StopCoroutine(FadeToBlack());
    }

    IEnumerator FadeToScreen()
    {
        Debug.Log("Fade to Screen");
        fadeON = true;

        if (fadeON == true)
        {
            Color initialColour = fadeIMG.color;
            Color targetColour = new Color(initialColour.r, initialColour.g, initialColour.b, 0f);
            float elapsedTime = 0f;

            while (elapsedTime < fadeDuration)
            {
                elapsedTime += Time.deltaTime;
                fadeIMG.color = Color.Lerp(initialColour, targetColour, elapsedTime / fadeDuration);

                yield return null;
            }
        }
        StopCoroutine(FadeToScreen());
    }
}
