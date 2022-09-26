using System;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level_Load_Script_3 : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    int LevelNumber = 3;
    bool isLevelUnlocked = false;
    [SerializeField]
    Image blur;
    [SerializeField]
    Image Lock;
    [SerializeField]
    Image unlockImage;

    void Start()
    {
        isLevelUnlocked = levels_record.getCurrentLevel() >= LevelNumber ? true : false;
        if (isLevelUnlocked)
        {
            blur.enabled = false;
            Lock.enabled = false;
        }
        else
        {
            unlockImage.enabled = false;
        }


    }

    void Update()
    {


    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (levels_record.getCurrentLevel() >= LevelNumber - 1)
        {
            SceneManager.LoadScene(LevelNumber);
        }
    }
}
