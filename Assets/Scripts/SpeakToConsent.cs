using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeakToConsent : MonoBehaviour {

    public TextMesh narratorText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.E) && Input.GetKey(KeyCode.RightShift))
        {
         
            BeginGame();
        }
    }

    void BeginGame()
    {
        bool timeToBegin = Time.time > 10;

        print("The Game is Starting");
        narratorText.text = "Great!  Let's get started in..." + Time.time.ToString("N1");
        //            timeLeft -= Time.deltaTime;
        if (timeToBegin == true)
        {
            Application.LoadLevel("Scene2");
        }
    }
}
