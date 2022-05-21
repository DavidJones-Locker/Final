using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
   // public int asteroidPoolSize = 5;
    public GameObject asteroid1Prefab;
   // public float spawnRate = 4f;
    //public float asteroidMin = -1f;
   // public float asteroidMax = 3.5f;

  //  private GameObject[] asteroid;
   // private Vector2 objectPoolPosition = new Vector2(-15f, -25f);

    // Start is called before the first frame update
    void Start()
    {
        ///asteroid = new GameObject[asteroidPoolSize];
       // for (int i = 0; i < asteroidPoolSize; i++)
        {
      //      asteroid[i] = (GameObject)Instantiate(asteroid1Prefab, objectPoolPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    /*void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;

        if (GameControl.instance.gameOver == false && timeSinceLastSpawned >= spawnRate)
        {
            timeSinceLastSpawned = 0;
            float spawnYPosition = Random.Range(asteroidMin, asteroidMax);
            asteroid[currentAsteroid].transform.position = new Vector2(spawnXPosition, spawnYPosition);
            currentAsteroid++;
            if (currentAsteroid >= columnPoolSize)
            {
                currentAsteroid = 0;
            }
        }
    }
    */

}
