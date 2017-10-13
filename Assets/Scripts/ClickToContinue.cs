using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickToContinue : MonoBehaviour {

	public string scene;
    public float sceneLoadDelay;
	private bool loadLock;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space") && sceneLoadDelay > 0) {
            Invoke("LoadScene", sceneLoadDelay);

		}
	}

    public void InvokeLoadScene (){
        Invoke("LoadScene", sceneLoadDelay); 
    }

	void LoadScene (){
		loadLock = true;
		SceneManager.LoadScene (scene);

	}

}
