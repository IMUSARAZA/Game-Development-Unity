
using UnityEngine;
using UnityEngine.UI;

public class GemScript : MonoBehaviour
{


    public AudioSource gemSound;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0, 9, 0);
        
    }

    private void OnTriggerEnter(Collider other)
    {
            gemSound.Play();
            Destroy(gameObject);

            

    }

    
}
