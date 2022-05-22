using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ButtonScript : MonoBehaviour

{
    public GameObject Kangaroo;
    public GameObject RightButton;
    Animator animator;
    public float jumpPower;
    public int jumpCount;
    public bool Check;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = Kangaroo.GetComponent<Animator>();
        Check = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ButtonLeft()
    {
        

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
            Invoke("ButtonRight2",0.5f);

        }

        if (Check == true)
        {
            animator.Play("Kangaroo Punch2");
            RightButton.GetComponent<Button>().interactable = false;
            Invoke("ButtonRight2", 0.5f);
        }

    }

    public void RetryButton()
    {
        SceneManager.LoadSceneAsync("Beginner Course");
    }

    public void ButtonLeft2()
    {
        this.gameObject.GetComponent<Button>().interactable = true;
    }

    public void ArrowButton1()
    {
        SceneManager.LoadSceneAsync("Intermediate Course Select");
    }

    public void ArrowButton2()
    {
        SceneManager.LoadSceneAsync("Beginner Course Select");
    }

    public void ArrowButton3()
    {
        SceneManager.LoadSceneAsync("Advanced Course Select");
    }

    public void ArrowButton4()
    {
        SceneManager.LoadSceneAsync("Intermediate Course Select");
    }

    public void StopButton()
    {
        Time.timeScale = 0;
    }

    public void ButtonRight2()
    {
        RightButton.GetComponent<Button>().interactable = true;
    }

    public void OperationButton()
    {
        SceneManager.LoadSceneAsync("Operation explanation1");
    }

    public void NextButton1()
    {
        SceneManager.LoadSceneAsync("Operation explanation2");
    }

    public void NextButton2()
    {
        SceneManager.LoadSceneAsync("Operation explanation3");
    }

    public void NextButton3()
    {
        SceneManager.LoadSceneAsync("Operation explanation4");
    }

    public void BackButton()
    {
        SceneManager.LoadSceneAsync("Start Scene");
    }

}
