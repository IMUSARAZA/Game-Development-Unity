using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour

{
    public Text winMsg;
    public GameObject[] gems;
    public GameObject unity;

    public GameObject gtimer;

    void Start()
    {
        
    }

    void Update()
    {

        gems = GameObject.FindGameObjectsWithTag("TheGem");
            if(gems.Length == 0){
                winMsg.text = "You have won the game, Game will restart in 3 seconds";
                Destroy(gtimer);
                StartCoroutine(restartGame());
            }
        
    }

    IEnumerator restartGame()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);
    }


}
