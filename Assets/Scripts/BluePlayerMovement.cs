using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
	public float xMin, xMax, yMin, yMax;
}


public class BluePlayerMovement : MonoBehaviour
{

	[SerializeField] Rigidbody2D bluePlayerRB;
	public Boundary boundary;

	void Start()
	{
		bluePlayerRB = GetComponent<Rigidbody2D>();
	}

	void Update()
	{

		bluePlayerRB.position = new Vector2
            (

                Mathf.Clamp (bluePlayerRB.position.x, boundary.xMin, boundary.xMax),

                Mathf.Clamp (bluePlayerRB.position.y, boundary.yMin, boundary.yMax)
            
            );
	}

}


