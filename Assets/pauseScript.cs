using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pauseScript : MonoBehaviour
{

    Button pauseButton;
    [SerializeField]
    GameObject pauseMenuComponent;
    

    private void Awake()
    {
        pauseButton = GetComponent<Button>();
        Debug.Log("pause" + pauseButton);
        pauseMenuComponent.SetActive(false);
        
    }
    // Start is called before the first frame update
    void Start()
    {
        pauseButton.onClick.AddListener(showPauseScreen);

    }

    // Update is called once per frame
    void Update()
    {
        if (pauseButton == null)
        {
            pauseButton.onClick.AddListener(showPauseScreen);
        }
    }

    void showPauseScreen()
    {
        Debug.Log("called");
        Time.timeScale = 0;
        pauseMenuComponent.SetActive(true);
    }



  
}
