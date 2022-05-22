using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearScript : MonoBehaviour
{
    
    public GameObject Main;
    public GameObject Clear;
    public ClearScript2 script;
    //public bool clear;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
        animator = Main.GetComponent<Animator>();
        script = Clear.GetComponent<ClearScript2>();
    }

    // Update is called once per frame
    void Update()
    {
        

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Kangaroo3")
        {
            Main.SetActive(true);
            //clear = true;
            Invoke("ClearDown", 2.5f);
        }
    }

    void ClearDown()
    {
        animator.Play("Clear Animation Down");
        script.speed = 0;
    }
}
