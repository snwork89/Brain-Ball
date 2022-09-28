using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        Ad_Manager.instance.Show_Ad();
        StartCoroutine(loadScene());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator loadScene()
    {
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene(1);
    }
}
