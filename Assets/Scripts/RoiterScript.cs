using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoiterScript : MonoBehaviour
{
    Animator animator;
    public bool Roiter;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Kangaroo3")
        {
            animator.Play("Roiter Animation");
            Roiter = true;
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Kangaroo3")
        {
            
            Roiter = false;
        }
    }
}
