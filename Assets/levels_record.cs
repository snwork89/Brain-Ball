using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Cinemachine.DocumentationSortingAttribute;

public class levels_record : MonoBehaviour
{
   

    private void Start()
    {
        if (PlayerPrefs.GetFloat("level_passed") == null)
        {
            PlayerPrefs.SetFloat("level_passed", 0f);
        }
    }

    public static void changeLevelsPassed(float level)
    {
       
        PlayerPrefs.SetFloat("level_passed", level);
        PlayerPrefs.Save();
    }

   public static float getCurrentLevel()
    {
        return PlayerPrefs.GetFloat("level_passed");
    }
}
