using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] asteroidPrefabs;
    private float spawnrangeY = 5;

    private float startDelay = 1;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAsteroid", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnRandomAsteroid()
    {
        int asteroidIndex = Random.Range(0, asteroidPrefabs.Length);
        Vector2 spawnPos = new Vector2(0,Random.Range(-spawnrangeY, spawnrangeY));
        Instantiate(asteroidPrefabs[asteroidIndex], spawnPos, asteroidPrefabs[asteroidIndex].transform.rotation);
    }
}
