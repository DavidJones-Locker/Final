using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
    private Vector2 startPos;
    public float speed = 20;
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        transform.position = new Vector3((pos.x - Time.deltaTime * speed) %(0.32f* 21.914f), 0.03f, 0); 
    }

}
