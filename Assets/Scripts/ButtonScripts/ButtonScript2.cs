using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ButtonScript2 : MonoBehaviour

{
    public GameObject Kangaroo;
    public GameObject RightButton;
    Animator animator;
    public float jumpPower;
    public int jumpCount;
    public bool Check;
    public GameObject Roiter;
    public RoiterScript script;
    // Start is called before the first frame update
    void Start()
    {
        animator = Kangaroo.GetComponent<Animator>();
        Check = false;
        script = Roiter.GetComponent<RoiterScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ButtonLeft()
    {
        if (script.Roiter == true)
        {

            jumpPower = 1.7f * jumpPower;

        }

        if (script.Roiter == false)
        {
            jumpPower = 5;
        }

        if (Check == false)
        {
            if (jumpCount == 0 || jumpCount == 1)
            {
                animator.Play("Kangaroo Jump");
                Kangaroo.GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpPower);
                jumpCount += 1;
            }

            if (jumpCount >= 2)
            {
                this.gameObject.GetComponent<Button>().interactable = false;
            }

        }

        if (Check == true)
        {
            if (jumpCount == 0 || jumpCount == 1)
            {
                animator.Play("Kangaroo Jump2");
                Kangaroo.GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpPower);
                jumpCount += 1;
            }

            if (jumpCount >= 2)
            {
                this.gameObject.GetComponent<Button>().interactable = false;
            }
        }

        

        
    }

    public void ButtonRight()
    {
        if (Check == false)
        {
            animator.Play("Kangaroo Punch");
            RightButton.GetComponent<Button>().interactable = false;
            Invoke("ButtonRight2",1);

        }

        if (Check == true)
        {
            animator.Play("Kangaroo Punch2");
        }

    }

    public void RetryButton()
    {
        SceneManager.LoadScene("Beginner Course");
    }

    public void ButtonLeft2()
    {
        this.gameObject.GetComponent<Button>().interactable = true;
    }

    public void ArrowButton1()
    {
        SceneManager.LoadScene("Intermediate Course Select");
    }

    public void ArrowButton2()
    {
        SceneManager.LoadScene("Beginner Course Select");
    }

    public void ArrowButton3()
    {
        SceneManager.LoadScene("Advanced Course Select");
    }

    public void ArrowButton4()
    {
        SceneManager.LoadScene("Intermediate Course Select");
    }

    public void StopButton()
    {
        Time.timeScale = 0;
    }

    public void ButtonRight2()
    {
        RightButton.GetComponent<Button>().interactable = true;
    }
}
