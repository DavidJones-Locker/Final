using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    
        public GameObject[] asteroidPrefabs;
        private float spawnrangeY = 20;

        // Start is called before the first frame update
        void Start()
        {
            InvokeRepeating("SpawnRandomAsteroid", 2, 1.5f);
        }

        // Update is called once per frame
        void Update()
        {

        }
        void SpawnRandomAsteroid()
        {
            int asteroidIndex = Random.Range(0, asteroidPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnrangeY, spawnrangeY), 0);
            Instantiate(asteroidPrefabs[asteroidIndex], spawnPos, asteroidPrefabs[asteroidIndex].transform.rotation);
        }
}

