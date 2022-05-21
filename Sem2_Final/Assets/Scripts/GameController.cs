using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public GameObject gameOverText;
    public bool gameOver = false;
    public float scrollSpeed = -1.5f;
    public Text scoreText;

    private int score = 0;

    public AudioClip scoredClip;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver == true && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

   public void PassedAsteroid ()
    {
        if (gameOver)
        {
            return;
        }
    score++;
    scoreText.text = "Score:" + score.ToString();

    PlaySound(scoredClip);
    }

  public void SpaceshipCrash()
    {
    gameOverText.SetActive(true);
    gameOver = true;
}

 public void PlaySound(AudioClip clip)
{
    audioSource.PlayOneShot(clip);
}
}


