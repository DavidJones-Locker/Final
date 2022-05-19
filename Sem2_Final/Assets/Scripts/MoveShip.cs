using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShip : MonoBehaviour
{
    private bool isDead = false;
    private Rigidbody2D rb2d;
    public float upForce = 200f;
    //private Animator anim;
    // AudioSource audio; 

    // public AudioClip flap;

    // Start is called before the first frame update
    void Start()
    {
        //  anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        // audio = GetComponent<AudioSource>();
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

                // audio.PlayOneShot(flap);
            }

        }


    }
    void OnCollisionEnter2D()
    {
        rb2d.velocity = Vector2.zero;
        isDead = true;
        //  anim.SetTrigger("Die");
        //GameControl.instance.BirdDied();
    }

}
