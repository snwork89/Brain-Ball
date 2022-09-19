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


    }

    void Update()
    {


    }

    public void OnPointerClick(PointerEventData eventData)
    {
        SceneManager.LoadScene(LevelNumber);
    }
}
