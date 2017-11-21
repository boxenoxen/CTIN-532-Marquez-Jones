using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorTransform : MonoBehaviour {
	[SerializeField] Transform _transformToMirror;
	Vector3 _difference;

	// Use this for initialization
	void Start () {
		_difference = _transformToMirror.position - transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = _transformToMirror.position - _difference;
	}
}
