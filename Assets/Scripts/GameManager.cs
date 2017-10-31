using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {


    public bool gameOver;
    public static GameManager _gameManagerInstance = null;


    public float sceneLoadDelay;
    private bool loadLock;

	// Use this for initialization

    void Awake()
    {
        if (_gameManagerInstance == null)
        {
            _gameManagerInstance = this;
        }
        else if (_gameManagerInstance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(this);
    }

	void Start () {

        //gameOver = false;


	}

    void Update()
    {
        if (Input.GetKeyDown("space") && sceneLoadDelay > 0)
        {
            Invoke("LoadScene", sceneLoadDelay);

        }

        if (Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene("SplashScene");
    }

    
    public void LoadScene()
    {
        loadLock = true;
        //metrics stuff
		//Debug.Log(scene);
		if (MetricManagerScript._metricsInstance != null) {
			MetricManagerScript._metricsInstance.LogTime ("Scene " + SceneManager.GetActiveScene ().name + " Transition:");
		}

		if (SceneManager.sceneCountInBuildSettings != SceneManager.GetActiveScene ().buildIndex + 1) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
		}
    }



    //public void GameOver() {

    //    gameOver = true; 

    //    SceneManager.LoadScene("SplashScene", LoadSceneMode.Additive); 
    //}

 }

