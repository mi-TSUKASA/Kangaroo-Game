﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KangarooScript3 : MonoBehaviour
{
    //Dolfinはイルカのアニメーションを始める合図
    public float speed;
    public GameObject jumpButton;
    public GameObject punchButton;
    public GameObject DolfinCheck;
    public GameObject UniChecker;
    public ButtonScript2 script2;
    public ButtonScript2 script;
    public bool Dolfin;
    int stageNum = 0;


    Animator animator;
   
    // Start is called before the first frame update
    void Start()
    {
        //Checkはカンガルーがイルカエリアに入ったかどうか判断(ボタン）
        jumpButton = GameObject.Find("ButtonLeft");
        punchButton = GameObject.Find("ButtonRight");
        script = jumpButton.GetComponent<ButtonScript2>();
        script2 = punchButton.GetComponent<ButtonScript2>();
        animator = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += new Vector3(speed*Time.deltaTime,0,0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Obstacle"||collision.gameObject.tag=="Uni")
        {
            SceneManager.LoadScene("LoseScene3");
        }

        if (collision.gameObject.tag == "GOAL")
        {
            stageNum = 3;
            SceneManager.LoadScene("WinScene3");
            PlayerPrefs.SetInt("stageNumber", stageNum);
        }

        if (collision.tag == "Dolfin Checker")
        {
            UniChecker.SetActive(true);
            Destroy(DolfinCheck);
            speed = 0;
            animator.Play("Kangaroo Idle");
            script.Check = true;
            script2.Check = true;
            Dolfin = true;
            
        }
    }
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            script.jumpCount = 0;
            script.ButtonLeft2();
        }
    }

    
}
