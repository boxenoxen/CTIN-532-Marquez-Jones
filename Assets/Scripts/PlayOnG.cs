using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnG : MonoBehaviour {

	public AudioSource someSound;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.G)) {
			someSound.Play ();

		}
		
	}
}
