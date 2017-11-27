using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarPrefabMovement : MonoBehaviour {

	float rangeX;
	Vector3 velocity;

	// Use this for initialization
	void Start () {
		
	}

	public void SettingVelocity()
	{
		rangeX = Random.Range(-0.2f, -0.06f);

		velocity = new Vector3(rangeX, 0f, 0f);

	}

	void Update()
	{
		transform.Translate(velocity);
	}
}
