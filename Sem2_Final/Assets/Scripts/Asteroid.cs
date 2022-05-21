using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public AudioClip scoredClip;
    AudioSource audioSource;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<MoveShip>() != null)
        {
            GameController.instance.PassedAsteroid();
        }
    }

    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }

}
