using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




                        // FA21-BCS-140 (Musa Raza)  // Random velocity is added to the sphere when it respawns // 


public class SphereScript : MonoBehaviour
{
    public Rigidbody rb;
    public Text score;

    public Text display;

    public GameObject player;

    static int count = 0; 
    // Start is called before the first frame update
    void Start()
    {   
        count = 0;
        score.text = "Score: " + count;
        respawn();
    }
    void respawn()
    {
        float randx = Random.Range(-20, 20);
        float randy = Random.Range(0, 18);
        transform.position = new Vector3(randx, randy);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -11){
            if(count <= 100){
                count++;
                score.text = "Score: " + count;
                respawn();
                float randy = Random.Range(-25, 5); 
                rb.velocity = new Vector3(0,randy,0);
            }
            else{
                display.text = "Game Over";
                Destroy(player);
            }
        }
    }
}
