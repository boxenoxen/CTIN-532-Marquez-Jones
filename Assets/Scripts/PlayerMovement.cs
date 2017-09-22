using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	[SerializeField] KeyCode[] _inputKeys = new KeyCode[4] { KeyCode.W, KeyCode.A, KeyCode.S, KeyCode.D };

	Rigidbody2D _rigidBody2D;
	[SerializeField] float _sideForce = 1500.0f;
	[SerializeField] float _upForce = 2000.0f;
	[SerializeField] float _downForce = 1000.0f;

	// Use this for initialization
	void Awake()
	{
		_rigidBody2D = gameObject.GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(_inputKeys[0]))
		{
			_rigidBody2D.AddForce(Vector2.up * _upForce);
		}
		else if (Input.GetKeyDown(_inputKeys[1]))
		{
			_rigidBody2D.AddForce(Vector2.left * _sideForce);
		}
		else if (Input.GetKeyDown(_inputKeys[2]))
		{
			_rigidBody2D.AddForce(Vector2.down * _downForce);
		}
		else if (Input.GetKeyDown(_inputKeys[3]))
		{
			_rigidBody2D.AddForce(Vector2.right * _sideForce);
		}
	}
}
