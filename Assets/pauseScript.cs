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
        pauseButton.onClick.AddListener(showPauseScreen);
    }
    // Start is called before the first frame update
    void Start()
    {
          
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void showPauseScreen()
    {
        pauseMenuComponent.SetActive(true);
    }
}
