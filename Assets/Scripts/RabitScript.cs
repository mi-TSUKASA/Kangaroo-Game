using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabitScript : MonoBehaviour
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
        Invoke("RabitAnimation", 15.3f);

    }

    void RabitAnimation()
    {
        animator.Play("Rabit Animation");
    }
}
