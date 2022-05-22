using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SuperManScript : MonoBehaviour
{
    public GameObject Dolfin;
    public DolfinScript dolfinScript;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

        Dolfin = GameObject.Find("Dolfin");
        dolfinScript = Dolfin.GetComponent<DolfinScript>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        if (dolfinScript.DolfinFinished == true)
        {
            speed = 8;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Kangaroo2")
        {
            SceneManager.LoadScene("LoseScene2");
            //Invoke("LoseScene", 1);
        }
    }

    public void LoseScene()
    {
        
        SceneManager.LoadScene("LoseScene2");
    }
}
