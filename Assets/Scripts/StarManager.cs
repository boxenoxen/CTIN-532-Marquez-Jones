using UnityEngine;
using System.Collections;

public class StarManager : MonoBehaviour {

    private GameManager gameManager;

	public GameObject starPrefab;
	//private float interval;

	public Vector3 spawnValues;
	public int starCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;

	// Use this for initialization
	void Start () {
        StartCoroutine(SpawnNext());

		GameObject gameManagerObject = GameObject.FindWithTag("GameManager");

		if (gameManagerObject != null)
		{
		    gameManager = gameManagerObject.GetComponent<GameManager>();
		}
		if (gameManager == null)
		{
		    Debug.Log("Cannot find 'GameManager' script");

		}
	}

  //  void Update () {
		//InvokeRepeating("SpawnNext", 0, interval);
    //}

 //   IEnumerator SpawnNext() {
	//	// Instantiate
	//	GameObject newStar =(GameObject)Instantiate(prefab, transform.position, Quaternion.identity);

 //       velocity = new Vector2 (Random.Range(-.5f, -5f), 0 );




    IEnumerator SpawnNext()
    {

        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < starCount; i++)
            {
                //SPAWNING STARS
                GameObject starPrefabToSpawn = (GameObject)Instantiate(starPrefab, transform.position, Quaternion.identity);

                //SETTING POSITION
                GameObject newStar = Instantiate(starPrefabToSpawn, new Vector3(spawnValues.x, Random.Range(-spawnValues.y, spawnValues.y), spawnValues.z), Quaternion.identity);

                //Quaternion spawnRotation = Quaternion.identity;
                yield return new WaitForSeconds(spawnWait);

				newStar.GetComponent<StarPrefabMovement>().SettingVelocity();
            }

            yield return new WaitForSeconds(waveWait);

            if (gameManager.gameOver)
            {
                break;
            }
        }
    }
}