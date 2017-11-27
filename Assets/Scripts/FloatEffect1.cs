using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatEffect1 : MonoBehaviour {

	private float startY = 0f;
	private float duration = .2f;
	private Transform transform;



	// Use this for initialization
	void Start () {
		transform = GetComponent<Transform> ();
		startY = transform.position.y;

	}
	
	// Update is called once per frame
	void Update () {
		var newY = startY + (startY + Mathf.Cos(Time.time/ duration * 1 )) / 2.5f;
		transform.position = new Vector2(transform.position.x, newY);

	}
}
