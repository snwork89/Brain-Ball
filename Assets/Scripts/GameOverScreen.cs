using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreen : MonoBehaviour
{

    void Start()
    {
        gameObject.SetActive(false);
    }

    public void SetUp()
    {
        gameObject.SetActive(true);
            
    }

   
}
