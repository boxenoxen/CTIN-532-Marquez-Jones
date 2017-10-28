using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RockSpawner : MonoBehaviour {

	// Prefab for instantiating apples 
	public GameObject boulderPrefab; 

	// Speed at which the AppleTree moves in meters/ second 
	public float speed = 1f; 

	// Distance where AppleTree turns around 
	public float leftAndRightEdge = 10f; 

	// Chance that the AppleTree will change directions 
	public float chanceToChangeDirections = 0.1f; 

	// Rate at which Apples will be instantiated 
	public float secondsBetweenRockDrops = 1f;

	// Use this for initialization
	void Start () {
		//dropping apples every second
		InvokeRepeating( "DropRock", 2f, secondsBetweenRockDrops ); 
	} 

	void DropRock() { 
		GameObject boulder = Instantiate(boulderPrefab) as GameObject; 
		boulder.transform.position = transform.position;

	}

	// Update is called once per frame
	void Update () {
		//basic movement
		Vector3 pos = transform.position; 
		pos.x += speed * Time.deltaTime; 
		transform.position = pos;

		//changing direction
		if (pos.x < -leftAndRightEdge) { 
			speed = Mathf.Abs (speed); // Move right 
		} else if (pos.x > leftAndRightEdge) { 
			speed = -Mathf.Abs (speed); // Move left 

		}

	}

	void FixedUpdate(){

		//Changing Direction Randomly
		if (Random.value < chanceToChangeDirections) { 
			speed *= -1; // Change direction 
		}
	}


}
