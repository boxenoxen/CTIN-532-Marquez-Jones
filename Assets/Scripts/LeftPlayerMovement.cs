using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPlayerMovement : MonoBehaviour {
    private Rigidbody2D LeftPlayerRB;
    // Use this for initialization
    void Start() {
        LeftPlayerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.W))
        {
            LeftPlayerRB.transform.Translate(Vector3.up);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            LeftPlayerRB.transform.Translate(Vector3.down);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            LeftPlayerRB.transform.Translate(Vector3.right);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            LeftPlayerRB.transform.Translate(Vector3.left);
        }
       
    }
}