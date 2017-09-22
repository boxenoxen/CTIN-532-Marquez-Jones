using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnL : MonoBehaviour {

	public AudioSource someOtherSound;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.L)) {
			someOtherSound.Play ();
		}
		
	}
}
