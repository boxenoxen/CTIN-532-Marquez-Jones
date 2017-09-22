using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

    private GameManager gameManager;

	private AudioSource collisionAudioSource;

	public AudioClip collisionAudioClip_Kiss;
    public AudioClip collisionAudioClip_Honk;

	// Use this for initialization
	void Start () {

        //GameObject gameManagerObject = new GameObject.FindWithTag("GameManager");
      
        //if(gameManagerObject != null){
            
        //    gameManager = gameManagerObject.GetComponent<GameManager>();
        //}

        //if(gameManager == null){

            //Debug.Log("Cannot Find 'Game Manager' script");
        //}
	}

    void OnCollision2D (Collider2D other){
		if (other.tag == "RP_Head"){
            collisionAudioSource.clip = collisionAudioClip_Kiss;
            collisionAudioSource.Play();
            print("We have kissed!");
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
