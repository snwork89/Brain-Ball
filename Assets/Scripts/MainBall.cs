using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainBall : MonoBehaviour
{
    [SerializeField]
    GameOverScreen gameOverScreen;
    AudioSource gameOverSound;

    private void Start()
    {
        gameOverSound = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
      
        Debug.Log(collision.collider.tag);
        if (collision.collider.tag == "GameOver")
        {
            gameOverSound.Play();
            Time.timeScale = 0;
            gameOverScreen.SetUp();
         /*   FindObjectOfType<GameManager>().EndGame();*/

        }
        if(collision.collider.tag=="LevelDone")
        {
            if (SceneManager.GetActiveScene().buildIndex == 3)
                
            {
                GameManager.showAd();
                SceneManager.LoadScene(0);
            }
            else
            {
                FindObjectOfType<GameManager>().GoToNextLevel();
            }
        }




    }
}
