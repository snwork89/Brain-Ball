using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.Advertisements;
public class GameManager : MonoBehaviour,IUnityAdsLoadListener
{
    bool isGameEnded = false;

    public GameOverScreen screenGameOver;
    private void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();

                return;
            }
        }
    }
    public void EndGame()
    {
        if (isGameEnded == false)
        {
            isGameEnded = true;

            screenGameOver.SetUp();
            //Restart();
        }
    }

    public void GoToNextLevel()
    {
        Ad_Manager.instance.Show_Ad();
        if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            float newLevel = levels_record.getCurrentLevel() + 1;
            levels_record.changeLevelsPassed(newLevel);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void OnUnityAdsAdLoaded(string placementId)
    {
        throw new System.NotImplementedException();
    }

    public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message)
    {
        throw new System.NotImplementedException();
    }
}
