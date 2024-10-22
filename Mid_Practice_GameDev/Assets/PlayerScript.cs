using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update

    public int speed = 10;
    Vector3 pos;
    void Start()
    {
        pos = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
  
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;

        pos.x += x; 
        pos.x = Mathf.Clamp(pos.x, -14, 14);
        transform.position = pos;

        
    }


    private void OnCollisionEnter(Collision collision){

        SceneManager.LoadScene(0);

    }

}
