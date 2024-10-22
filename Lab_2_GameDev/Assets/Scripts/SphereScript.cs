using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SphereScript : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = Vector3.zero;
        rb.AddForce(new Vector3(1,0.5f)*Time.deltaTime*5);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -10){
            SceneManager.LoadScene(1);
        }
    }
}