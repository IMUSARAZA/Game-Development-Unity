using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{

    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -4){
            respwan();
        } 
    }

    void respwan(){
        float x = Random.Range(-14, 14);
        float y = Random.Range(-5, 15);
        transform.position = new Vector3(x, y, 0);
        rb.velocity = Vector3.zero;
    }
}
