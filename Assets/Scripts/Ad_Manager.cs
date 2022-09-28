using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class Ad_Manager : MonoBehaviour
{
    public static Ad_Manager instance;
    string Game_Id = "4946916";
    private float waitTime = 5f;
    [SerializeField] GameObject LoadingUI;
    // Start is called before the first frame update

    private void Awake()
    {
        if(instance == null)
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
        StartCoroutine(ShowAd());
    }

    private IEnumerator ShowAd()
    {
        float currentTime = 0.0f;

        LoadingUI.SetActive(true);

        while (currentTime <= waitTime && !Advertisement.isInitialized)
        {
            currentTime += Time.deltaTime;
            yield return null;
        }

        // show the ad if it is now ready
        if (Advertisement.isInitialized)
        {
            Advertisement.Show("Interstitial_Android");
        }
        else
        {
            Debug.LogError("Error: Ad was not able to be loaded in " + waitTime + " seconds!");
        }

        LoadingUI.SetActive(false);
    }
}