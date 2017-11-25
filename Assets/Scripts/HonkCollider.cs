using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HonkCollider : MonoBehaviour {

	[SerializeField] AudioManager audioManager;
	[SerializeField] ParticleSystem star;

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.collider.tag == "PlayerTwo_Pelvis")
		{
			audioManager.PlayHonkSound();
			star.Play ();

		}
	}
}
