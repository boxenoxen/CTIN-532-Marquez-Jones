using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhistleCollider_PlayerTwo : MonoBehaviour {

    [SerializeField] AudioManager audioManager;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "PlayerOne_Pelvis")
        {
            audioManager.PlayWhistleSound();
        }
    }
}
