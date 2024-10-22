using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public int speed = 50;
    // In unity every public variable is serializable, i.e. it becomes a part of main class
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 vec = new Vector3(x, y);
        transform.position += vec * Time.deltaTime * speed;
        //transform.position is actual position of player
        //vec is position gotten from the keyboard
        /*
            to convert frame rate into real time multiply calculation with Time.deltaTime
        */
    }

    public void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(0);
    }
}