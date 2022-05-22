using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GOALScript : MonoBehaviour
{
    Animator animator; 

    void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Punch")
            {

            animator.Play("Hae Damaged Animation");
            this.GetComponent<BoxCollider2D>().enabled = false;
            }

        if (collision.gameObject.tag == "Kangaroo3")
        {
            SceneManager.LoadScene("LoseScene3");
        }
    }
}