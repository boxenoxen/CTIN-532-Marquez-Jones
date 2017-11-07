using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RockSpawner : MonoBehaviour {

    private GameManager gameManager;

	public GameObject rockPrefab;

    public Vector3 spawnValues;
    public int rockCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;

	[SerializeField] float _minimumBoulderSize = 0.3f;
	[SerializeField] float _maximumBoulderSize = 1.1f;

	bool _isRocksFlowing = true;

	// Use this for initialization
	void Start () {

        StartCoroutine(SpawnNext());
      //GameObject gameManagerObject = GameObject.FindWithTag("GameManger");

	} 


    IEnumerator SpawnNext()
    {
        yield return new WaitForSeconds(startWait);
		while (_isRocksFlowing)
        {
            for (int i = 0; i < rockCount; i++)
            {
                GameObject rockPrefabToSpawn = (GameObject)Instantiate(rockPrefab, transform.position, Quaternion.identity);
				float randomBoulderSize = Random.Range (_minimumBoulderSize, _maximumBoulderSize);
				rockPrefabToSpawn.transform.localScale = new Vector3 (randomBoulderSize, randomBoulderSize, randomBoulderSize);
                //GameObject newRock = Instantiate(rockPrefabToSpawn, new Vector3(Random.Range(-spawnValues.x, spawnValues.x),spawnValues.y, 0), Quaternion.identity);

                yield return new WaitForSeconds(spawnWait);
                
            }

            yield return new WaitForSeconds(waveWait);
        }
    }
}
