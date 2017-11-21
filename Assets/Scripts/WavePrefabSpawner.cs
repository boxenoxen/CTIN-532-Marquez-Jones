﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WavePrefabSpawner : MonoBehaviour {

    public GameObject wavePrefab;

    public Vector3 spawnValues;
    public int waveCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;

    // Use this for initialization
    void Start () {

        StartCoroutine(SpawnNext());

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator SpawnNext()
    {

        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < waveCount; i++)
            {
                //SPAWNING WAVES
                int planetIndex = Random.Range(0, planetPrefabs.Length);
                GameObject planetPrefabToSpawn = planetPrefabs[planetIndex];

                //SETTING POSITION
                GameObject newPlanet = Instantiate(planetPrefabToSpawn, new Vector3(spawnValues.x, Random.Range(-spawnValues.y, spawnValues.y), spawnValues.z), Quaternion.identity);

                //Quaternion spawnRotation = Quaternion.identity;
                yield return new WaitForSeconds(spawnWait);

                //SETTING SPEED FOR PLANETS
                newPlanet.GetComponent<WavePrefabMovement>().SettingVelocity();
            }

            yield return new WaitForSeconds(waveWait);

            if (gameOver)
            {
                break;
            }

        }
    }
}
