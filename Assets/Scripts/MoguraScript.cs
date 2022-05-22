using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoguraScript : MonoBehaviour
{
    public GameObject Mogura;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = Mogura.GetComponent<Animator>();
        Invoke("MoguraAnimation", 7.7f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MoguraAnimation()
    {
        animator.Play("Mogura Animation");
    }
    
}
