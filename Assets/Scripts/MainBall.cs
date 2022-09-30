using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainBall : MonoBehaviour
{
    [SerializeField]
    GameOverScreen gameOverScreen;
    AudioSource gameOverSound;
    bool isOut = false;

    private void Start()
    {
        gameOverSound = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
      
        Debug.Log(collision.collider.tag);
        if (collision.collider.tag == "GameOver")
        {
            if (!isOut)
            {
                gameOverSound.Play();

                gameOverScreen.SetUp();
            }
            isOut = true;
         
         /*   FindObjectOfType<GameManager>().EndGame();*/

        }
        if(collision.collider.tag=="LevelDone")
        {
            if (SceneManager.GetActiveScene().buildIndex == 4)
                
            {
                Ad_Manager.instance.Show_Ad();
                SceneManager.LoadScene(0);
            }
            else
            {
                FindObjectOfType<GameManager>().GoToNextLevel();
            }
        }




    }
}
