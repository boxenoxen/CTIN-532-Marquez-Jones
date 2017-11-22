using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WavePrefabMovement : MonoBehaviour {

    //public float minXRange;
   // public float maxXRange;

    float rangeX;
    Vector3 velocity;

    // Use this for initialization
    void Start()
    {

    }

    public void SettingVelocity()
    {

        velocity = new Vector3(rangeX, 0f, 0f);

    }

    void Update()
    {
        rangeX = Random.Range(-.75f, .75f);

        transform.Translate(velocity);
    }


}

