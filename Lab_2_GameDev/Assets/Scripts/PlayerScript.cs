using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public int speed = 40;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        Vector3 vec = new Vector3(x,0);
        pos.x = Mathf.Clamp(pos.x, -28, 28);
        pos += vec*Time.deltaTime*speed;
        transform.position = pos;
        
    }
}