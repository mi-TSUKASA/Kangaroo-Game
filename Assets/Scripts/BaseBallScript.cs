using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BaseBallScript : MonoBehaviour
{
    public float speed;
    public float hitspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        {
            if (collision.gameObject.tag == "Punch")
            {
                speed = -30;
                
                
            }

            if (collision.gameObject.tag == "Kangaroo")
            {
                SceneManager.LoadScene("LoseScene");
            }

            if (collision.gameObject.tag == "Kangaroo2")
            {
                SceneManager.LoadScene("LoseScene2");
            }

            if (collision.gameObject.tag == "Kangaroo3")
            {
                SceneManager.LoadScene("LoseScene3");
            }

        }
    }
}
