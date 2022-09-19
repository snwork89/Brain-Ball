using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainBall : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
      
        Debug.Log(collision.collider.tag);
        if (collision.collider.tag == "GameOver")
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        if(collision.collider.tag=="LevelDone")
        {
            FindObjectOfType<GameManager>().GoToNextLevel();
        }




    }
}
