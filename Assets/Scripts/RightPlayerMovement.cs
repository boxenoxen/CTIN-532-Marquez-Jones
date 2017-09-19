using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPlayerMovement : MonoBehaviour {
    private Rigidbody RightPlayerRB;
    // Use this for initialization
    void Start () {
        RightPlayerRB = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            RightPlayerRB.transform.Translate(Vector3.up);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            RightPlayerRB.transform.Translate(Vector3.down);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            RightPlayerRB.transform.Translate(Vector3.right);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            RightPlayerRB.transform.Translate(Vector3.left);
        }

    }
}
