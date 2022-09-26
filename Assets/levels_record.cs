using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levels_record : MonoBehaviour
{
    public static float levels_unlocked = 0;
   
      public static void changeLevelsPassed(float level)
    {
        levels_unlocked = level;
    }

   public static float getCurrentLevel()
    {
        return levels_unlocked;
    }
}
