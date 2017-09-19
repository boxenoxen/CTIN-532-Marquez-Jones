using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour {
    public float xMin, xMax, yMin, yMax, zMin, zMax;
    private Rigidbody boundaryRB;
    public Boundary boundary;


	// Use this for initialization
	void Start () {
        boundaryRB = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		boundaryRB.position = new Vector3 (
            Mathf.Clamp(boundaryRB.position.x, boundary.xMin, boundary.xMax),

            Mathf.Clamp(boundaryRB.position.y, boundary.yMin, boundary.yMax),

            Mathf.Clamp(boundaryRB.position.z, boundary.zMin, boundary.zMax)
            );
	}
}

