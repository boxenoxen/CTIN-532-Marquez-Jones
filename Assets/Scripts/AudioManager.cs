using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

    private GameManager gameManager;

	public AudioSource gameAudioSource;

	public AudioClip collisionAudioClip_Kiss;
    public AudioClip collisionAudioClip_Honk;
    public AudioClip playerOneEmote;
    public AudioClip playerTwoEmote;

    public ParticleSystem playerOneParticles;
    public ParticleSystem playerTwoParticles;

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
            gameAudioSource.clip = collisionAudioClip_Kiss;
            gameAudioSource.Play();
            print("We have kissed!");
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E))
        {
            PlayerOneEmote();

        }
  
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            PlayerTwoEmote();
        }
    }

    private void PlayerOneEmote()
    {
        gameAudioSource.clip = playerOneEmote;
        gameAudioSource.Play();

        playerOneParticles.Play();

        print("Player One Emotes");
    }

    private void PlayerTwoEmote ()
    {
        gameAudioSource.clip = playerTwoEmote;
        gameAudioSource.Play();

        playerTwoParticles.Play();

        print("Player Two Emotes");
    }
}
