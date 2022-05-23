using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShip1 : MonoBehaviour
{
    private bool isDead = false;
    private Rigidbody2D rb2d;
    public float upForce = 300f;
    private Animator anim;
    AudioSource audioSource;

    public AudioClip fly;
    public AudioClip Crash;
    public AudioClip Score;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(0, upForce));

                PlaySound(fly);
            }

        }


    }
    void OnCollisionEnter2D()
    {
        rb2d.velocity = Vector2.zero;
        isDead = true;
        anim.SetTrigger("SpaceshipCrash");
        GameController.instance.SpaceshipCrash();

        PlaySound(Crash);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<MoveShip1>() != null)
        {
            GameController.instance.PassedAsteroid();
        }

    }
    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
}
