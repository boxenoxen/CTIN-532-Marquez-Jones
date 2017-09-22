using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayPartOnG : MonoBehaviour {

	public ParticleSystem particles;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.G)){
			particles.Play();
		}

		if(Input.GetKeyUp(KeyCode.G)){
			particles.Stop();
		}
		
	}
}
