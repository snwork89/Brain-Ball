using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.Advertisements;
public class GameManager : MonoBehaviour
{
    bool isGameEnded = false;

    public GameOverScreen screenGameOver;
    string gameId = "4940276";

    private void Start()
    {
        Advertisement.Initialize(gameId,false);
       
    }

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
        showAd();
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            levels_record.changeLevelsPassed(levels_record.getCurrentLevel() + 1);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

   public static void showAd()
    {
        if (Advertisement.isInitialized)
        {
            Advertisement.Show("Interstitial_Android");
        }
    }
}
