using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hintScript : MonoBehaviour
{
    CanvasRenderer canvas;
    float time = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponent<CanvasRenderer>();
        StartCoroutine(blinkText());
    }

    // Update is called once per frame
    void Update()
    {
        if (time <= 0)
        {
            canvas.SetAlpha(0);
        }
    }

    IEnumerator blinkText()
    {
       
        while(time > 0)
        {
            yield return new WaitForSeconds(0.5f);
            canvas.SetAlpha(0);
            yield return new WaitForSeconds(0.5f);
            canvas.SetAlpha(1);
            time = time - 1;
        }
    }
}
