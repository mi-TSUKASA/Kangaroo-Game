using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirddroppingsScript : MonoBehaviour
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
        this.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        Invoke("BirddroppingsAnimation", 13.4f);
    }

    void BirddroppingsAnimation()
    {
        GetComponent<SpriteRenderer>().enabled = true;
        GetComponent<BoxCollider2D>().enabled = true;
        animator.Play("Bird droppings");
        speed = 0;

    }


}
