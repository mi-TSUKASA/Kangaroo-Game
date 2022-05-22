using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UniScript : MonoBehaviour
{
    public float speed;
    public float hitspeed;
    public GameObject Kangaroo;
    public KangarooScript2 script3;
    public GameObject BaseBall3;
    public GameObject Dolfin;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        Kangaroo = GameObject.Find("Kangaroo");
        script3 = Kangaroo.GetComponent<KangarooScript2>();
        Invoke("DolfinThrow", 2.1f);
        Invoke("DolfinThrow2", 2.5f);
        animator = Dolfin.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        this.transform.position -= new Vector3(hitspeed * Time.deltaTime, 0, 0);

        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {

        
            

        if (collision.gameObject.tag == "Kangaroo2")
        {
            SceneManager.LoadScene("LoseScene2");
        }

        if (collision.gameObject.tag == "UniChecker")
        {
            script3.Dolfin = true;
            BaseBall3.SetActive(true);
            
            
            
        }
        
        
    }

    public void DolfinThrow()
    {
        this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
        this.gameObject.GetComponent<BoxCollider2D>().enabled = true;
        speed = 5.5f;
        script3.Dolfin = false;
        

    }
    public void DolfinThrow2()
    {
        this.tag = "Uni";
    }

    public void UniChecker()
    {

    }

    
}
