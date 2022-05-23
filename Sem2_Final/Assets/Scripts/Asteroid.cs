using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public AudioClip scoredClip;
    AudioSource audioSource;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<MoveShip1>() != null)
        {
            GameController.instance.PassedAsteroid();
        }

        if (GameController.instance.gameOver == true)
        {
            GameController.instance.PassedAsteroid();
            enabled = false;
        }
    }

    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }

}
