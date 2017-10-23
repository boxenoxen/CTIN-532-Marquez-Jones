using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Narrate;

public class RendezvousPrompt : MonoBehaviour
{

    public Text rendezvousPrompt; // Assign in inspector
    public Text narrationText;

    bool isListeningForRightShift = false;
    float howLongToWaitBeforeListening;
    float timeWaitedBeforeListening;

    bool timeHasRunOut = false;
    float timeSinceRightShift = 0;
    bool timerIsRunning = false;

    TimerNarrationTrigger narrationScript;


    public GameManager gameManager;
    public GameObject rendezvousPoint;


    void Start()
    {
        narrationScript = FindObjectOfType<TimerNarrationTrigger>();
        Narration narration = narrationScript.theNarration;
        Phrase[] phrases = narration.phrases;
        for (int i = 0; i < phrases.Length - 1; i++)
        {
            howLongToWaitBeforeListening += phrases[i].duration;
        }
        howLongToWaitBeforeListening += narrationScript.time;
        StartCoroutine("CountDown");

    }

    IEnumerator CountDown()
    {
        yield return new WaitForSeconds(howLongToWaitBeforeListening);
        isListeningForRightShift = true;
    }

    void Update()
    {

        if (isListeningForRightShift && (Input.GetKeyDown("right shift") || Input.GetKeyDown(KeyCode.E)))
        {
            timerIsRunning = true;
            rendezvousPrompt.gameObject.SetActive(true);

            //sets Narrate subtitle text to false
            narrationText.gameObject.SetActive(false);
        }

        if (timerIsRunning)
        {
            timeSinceRightShift += Time.deltaTime;
            timeHasRunOut = (timeSinceRightShift > 3f);
        }

        if (timeHasRunOut == true)
        {
            rendezvousPrompt.gameObject.SetActive(false);
            //GameManager._gameManagerInstance.InvokeLoadScene("Scene2");

            //set Narrate subtitle text to true again
            narrationText.gameObject.SetActive(true);

            enableRendezvousPoint();

        }

    }

    void enableRendezvousPoint ()
    {
        //rendezvousPoint = GameObject.FindWithTag("RendezvousPoint");

        rendezvousPoint.SetActive(true);
    }

}
