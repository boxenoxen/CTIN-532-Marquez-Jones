using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {


    public bool gameOver;
    public static GameManager _gameManagerInstance = null;


    string scene;
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
    }

    public void InvokeLoadScene(string sceneToLoad)
    {
        scene = sceneToLoad;
        Invoke("LoadScene", sceneLoadDelay);
    }

    void LoadScene()
    {
        loadLock = true;
        //metrics stuff
        MetricManagerScript._metricsInstance.LogTime("Scene " + SceneManager.GetActiveScene().name + " Transition:");
        SceneManager.LoadScene(scene);

    }


    //public void GameOver() {

    //    gameOver = true; 

    //    SceneManager.LoadScene("SplashScene", LoadSceneMode.Additive); 
    //}

 }

