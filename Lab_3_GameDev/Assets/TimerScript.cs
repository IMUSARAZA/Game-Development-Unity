using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    // Start is called before the first frame update

    public Text timerDisplay;
    // public Text gameOver;
    public static int seconds = 20;
    bool isTakingTime = false;

    public GameObject unity;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!isTakingTime)
        {
            StartCoroutine(timerFunction());
        }
        else if(seconds == 0)
        {
            timerDisplay.text = "Game Lost!, Game will be restarted in 3 seconds.";
            // gameOver.text = "Game will be restarted in 3 seconds.";
            // Destroy(unity);
            // Destroy(timerDisplay);

            StartCoroutine(restartGame());
            
        }

    }

    IEnumerator restartGame()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(2);
    }

    IEnumerator timerFunction()
    {
        isTakingTime = true;
        yield return new WaitForSeconds(1);
        seconds--;
        timerDisplay.text = "Timer: " + seconds;
        isTakingTime = false;

    }
}
