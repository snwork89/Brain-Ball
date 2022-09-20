using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pauseMenu : MonoBehaviour
{
 
    Image backgroundImage;
    [SerializeField]
    Image menuImage;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void enablePauseMenu()
    {
        this.gameObject.SetActive(true);
    }

    public void disablePauseMenu()
    {
        this.gameObject.SetActive(false);
    }
}
