using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOScript : MonoBehaviour
{
    
    public float speed;
    Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = this.gameObject.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("UFO", 11.1f);
          
    }

    public void UFO()
    {


        this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
        this.gameObject.GetComponent<BoxCollider2D>().enabled = true;

        animator.Play("UFO Animation");

    }

    
}
