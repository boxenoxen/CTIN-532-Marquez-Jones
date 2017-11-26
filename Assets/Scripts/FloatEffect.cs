using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatEffect : MonoBehaviour {

	private float startY = 0f;
	private float duration = 1f;
	private Transform transform;



	// Use this for initialization
	void Start () {
		transform = GetComponent<RectTransform> ();
		startY = transform.position.y;

	}
	
	// Update is called once per frame
	void Update () {
		var newY = startY + (startY + Mathf.Cos(Time.time/ duration * 2 )) / .1f;
		transform.position = new Vector2(transform.position.x, newY);

	}
}
