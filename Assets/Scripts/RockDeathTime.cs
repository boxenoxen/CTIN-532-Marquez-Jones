using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockDeathTime : MonoBehaviour {
	float _rockDeathTime = 14.0f;

	void Start () {
		StartCoroutine (DeathCountDown ());		
	}
	
	// Update is called once per frame
	IEnumerator DeathCountDown(){
		yield return new WaitForSeconds (_rockDeathTime);
		Destroy (gameObject);
	}
}
