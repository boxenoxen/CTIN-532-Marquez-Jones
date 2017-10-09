using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

    private GameManager gameManager;

	public AudioSource playerOneAudioSource;
    public AudioSource playerTwoAudioSource;
    public AudioSource kissAudioSource;
    public AudioSource honkAudioSource;
    public AudioSource whistleAudioSource;

	public AudioClip collisionAudioClip_Kiss;
    public AudioClip collisionAudioClip_Honk;
    public AudioClip collisionAudioClip_Whistle;
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

    public void PlayKissSound()
    {
        kissAudioSource.clip = collisionAudioClip_Kiss;
        kissAudioSource.Play();
    }

    public void PlayHonkSound()
    {
        honkAudioSource.clip = collisionAudioClip_Honk;
        honkAudioSource.Play();
    }

    public void PlayWhistleSound()
    {
        whistleAudioSource.clip = collisionAudioClip_Whistle;
        whistleAudioSource.Play();
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

        if(!playerOneAudioSource.isPlaying) {
            playerOneParticles.Stop();
        }

		if (!playerTwoAudioSource.isPlaying)
		{
			playerTwoParticles.Stop();
		}
    }

    private void PlayerOneEmote()
    {
        playerOneAudioSource.clip = playerOneEmote;
        playerOneAudioSource.Play();

        playerOneParticles.Play();

        print("Player One Emotes");
    }

    private void PlayerTwoEmote()
    {
        playerTwoAudioSource.clip = playerTwoEmote;
        playerTwoAudioSource.Play();

        playerTwoParticles.Play();

        print("Player Two Emotes");
    }

   
}
