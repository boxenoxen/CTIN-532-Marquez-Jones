using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {


    public bool gameOver;


	// Use this for initialization
	void Start () {

        gameOver = false;


	}


    public void GameOver() {

        gameOver = true; 

        SceneManager.LoadScene("SplashScene", LoadSceneMode.Additive); 
    }

 }

