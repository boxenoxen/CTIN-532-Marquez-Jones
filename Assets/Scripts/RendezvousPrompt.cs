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

    private bool playerOneConsents = false;
    private bool playerTwoConsents = false; 

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

        //checking to make sure both player have consented
        if(isListeningForRightShift && Input.GetKeyDown(KeyCode.RightShift))
        {
            playerOneConsents = true; 
        }

        if (isListeningForRightShift && Input.GetKeyDown((KeyCode.E)))
        {
            playerTwoConsents = true; 
        }


        //displays prompt to incentivise players to rendezvous point
        if (isListeningForRightShift && playerOneConsents && playerTwoConsents)
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
