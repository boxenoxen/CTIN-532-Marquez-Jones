using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RendezvousPointProximityTrigger : MonoBehaviour {

    //public GameObject rendezvousPoint_GameObject;
    private GameObject rendezvousTextPrompt;

    private bool playerOneRendezvous = false;
    private bool playerTwoRendezvous = false;

    public GameManager gameManager;

    float timeLeft = 3f;

	// Use this for initialization
	void Start () 
    {
        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;
	}

    void OnTriggerEnter2D (Collider2D rendezvous)
    {
        if (rendezvous.gameObject.name == "POne_Torso")
        {

            if (timeLeft < 0)
            {
                playerOneRendezvous = true;
            }

            print("PlayerOne has Rendezvous'd");
        }

        if (rendezvous.gameObject.name == "PTwo_Torso")
        {

            if (timeLeft < 0)
            {
                playerTwoRendezvous = true; 
            }

            print("PlayerTwo has Rendezvous'd"); 
        }
        //else
        //{
        //    playerOneRendezvous = false;
        //    playerTwoRendezvous = false; 
        //}
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;

        if (playerOneRendezvous && playerTwoRendezvous == true)
        {
                gameManager.LoadScene();
        }
    }

}
