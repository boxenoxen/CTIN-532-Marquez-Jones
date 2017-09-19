﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPCollision : MonoBehaviour {

    private GameManager gameManager;

    public AudioSource rightPlayerAudioSource; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "LeftPlayer")
        {
            rightPlayerAudioSource.Play();



  //          gameManager.GameOver();
        }
    }

}
