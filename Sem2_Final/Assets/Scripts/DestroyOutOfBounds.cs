using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class DestroyOutOfBounds : MonoBehaviour
{
    private float leftBound = -30;
    //private float rightBound = 14;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // If an object goes past the players view in the game remove that object
        if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }
        //else if (transform.position.x < Bound)
        {
           // Debug.Log("Game Over!");
          //  Destroy(gameObject);
        }
         
}
}

