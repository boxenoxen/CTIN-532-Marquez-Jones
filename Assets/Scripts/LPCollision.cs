using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LPCollision : MonoBehaviour {

    private GameManager gameManager;

    public AudioSource leftPlayerAudioSource;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "RightPlayer")
        {
            leftPlayerAudioSource.Play();

            gameManager.GameOver();
        }
    }

}