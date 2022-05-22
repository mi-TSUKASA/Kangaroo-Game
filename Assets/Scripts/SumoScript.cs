using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumoScript : MonoBehaviour
{
    
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
        Invoke("Sumo", 12.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void Sumo()
    {
        animator.Play("Sumo Animation");
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {


    }
}
