using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlogScript : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("FlogAnimation", 17f);
    }

    void FlogAnimation()
    {
        animator.Play("Flog Animation");
    }

}
