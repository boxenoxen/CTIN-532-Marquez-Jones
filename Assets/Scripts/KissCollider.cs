using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class KissCollider : MonoBehaviour {
    [SerializeField] AudioManager audioManager;
	[SerializeField] ParticleSystem heart;

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.collider.tag == "PlayerTwo_Head")
		{
            audioManager.PlayKissSound();
			heart.Play ();

		}
	}
}
