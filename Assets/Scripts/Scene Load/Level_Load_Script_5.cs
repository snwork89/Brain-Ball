using System;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level_Load_Script_5 : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    int LevelNumber = 5;
    bool isLevelUnlocked = false;
    [SerializeField]
    Image blur;
    [SerializeField]
    Image Lock;
    [SerializeField]
    Image unlockImage;

    void Start()
    {
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
        SceneManager.LoadScene(LevelNumber);
    }
}
