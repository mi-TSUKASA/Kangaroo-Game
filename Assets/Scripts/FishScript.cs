using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FishScript : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = this.gameObject.GetComponent<Animator>();
        rotationSpeed += 180 * Time.deltaTime;
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
                this.gameObject.GetComponent<Animator>().enabled = false;
                
                speed = -25;
                


            }

            if (collision.gameObject.tag == "Kangaroo2")
            {
                SceneManager.LoadScene("LoseScene2");
            }
        }
    }
    void FishDestroy()
    {
        Destroy(this.gameObject);
    } 
}
