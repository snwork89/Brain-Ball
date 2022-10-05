using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;

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
      /* float currentScene = SceneManager.GetActiveScene().buildIndex;
        Debug.Log("current"+currentScene);
        if(currentScene > 0){
            LoadingUI.SetActive(false);
        }*/
    }
    void Start()
    {
        Advertisement.Initialize(Game_Id,false);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(levels_record.getCurrentLevel());
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
         
            Advertisement.Show("Rewarded_Android");
        }
        else
        {
            Debug.LogError("Error: Ad was not able to be loaded in " + waitTime + " seconds!");
        }

        LoadingUI.SetActive(false);
    }
}