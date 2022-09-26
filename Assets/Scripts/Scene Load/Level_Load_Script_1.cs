using System;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level_Load_Script_1 : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    int LevelNumber = 1;
    [SerializeField]
    Image unlockImage;
 

    void Start()
    {
       unlockImage.enabled = false;
        if (levels_record.getCurrentLevel() >= LevelNumber)
        {
            unlockImage.enabled = true;
        }

    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (levels_record.getCurrentLevel() >= LevelNumber - 1)
        {
            GameManager.showAd();
            SceneManager.LoadScene(LevelNumber + 1);
        }
    }
}
