using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class Ad_Manager : MonoBehaviour
{
    public static Ad_Manager instance;
    string Game_Id = "4940276";
    // Start is called before the first frame update

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        Advertisement.Initialize(Game_Id);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Show_Ad()
    {
        if (Advertisement.isInitialized)
        {
            Advertisement.Show("Interstitial_Android");
        }
    }
}