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

    public string sceneName;

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
            playerOneRendezvous = true;

            print("PlayerOne has Rendezvous'd");
        }

        if (rendezvous.gameObject.name == "PTwo_Torso")
        {
            playerTwoRendezvous = true; 

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
        if (playerOneRendezvous && playerTwoRendezvous == true)
        {
            ////Debug.Log("rendezvous is functional");
            //if (sceneName == "Scene3_1")
            //{
            //    SceneManager.LoadScene("WinState");
            //}

            //else
            //{
                gameManager.LoadScene();
            //}
        }
    }

}
