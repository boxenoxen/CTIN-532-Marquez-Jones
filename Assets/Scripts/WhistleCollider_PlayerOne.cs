using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhistleCollider_PlayerOne : MonoBehaviour {

    [SerializeField] AudioManager audioManager;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "PlayerTwo_Pelvis")
        {
            audioManager.PlayWhistleSound();
        }
    }
}