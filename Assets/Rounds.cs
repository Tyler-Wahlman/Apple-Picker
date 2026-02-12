using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Rounds : MonoBehaviour
{
    public Text roundText;     
    public int currentRound = 1;

    // Call this method whenever an apple is lost
    public void OnAppleMissed()
    {
        StartCoroutine(ShowRoundText());
        currentRound += 1;
    }

    IEnumerator ShowRoundText()
    {
        // 1. Set text and show
        roundText.text = "Round " + currentRound;
        roundText.enabled = true;

        // 2. Wait for 5 seconds
        yield return new WaitForSeconds(5f);

        // 3. Hide text
        roundText.enabled = false;
    }
}
