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

	// Use this for initialization
	void Start () 
    {

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
            //Debug.Log("rendezvous is functional");

            gameManager.LoadScene();
        }
    }

}
