using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DolfinScript : MonoBehaviour
{
    //DolfinTrowはBaseballのアニメーションを始める合図
    public GameObject Kangaroo;
    public KangarooScript2 script3;
    Animator animator;
    public bool DolfinThrow;
    public GameObject BaseBall;
    
    public GameObject BaseBall2;
    
    public GameObject Uni;

    public bool baseball;

    public GameObject BaseBall3;

    public GameObject Lake;

    public bool DolfinFinished;

    // Start is called before the first frame update
    void Start()
    {
        Kangaroo = GameObject.Find("Kangaroo");
        script3 = Kangaroo.GetComponent<KangarooScript2>();//上級コースで使うときは3にする
        animator = this.gameObject.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (script3.Dolfin == true && baseball==false)
        {
            BaseBall.SetActive(true);
            Invoke("DolfinAnimation", 1.5f);
            script3.Dolfin = false;
            baseball = true;
        }

        if(script3.Dolfin == true)
        {
            Invoke("DolfinAnimation", 1.5f);
            script3.Dolfin = false;
        }
        
    }

    void DolfinAnimation()
    {
        animator.Play("Dolfin Animation");

        
    }

   public void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.tag == "BaseBall")
        {
            animator.Play("Dolfin Damaged");
            BaseBall.SetActive(false);
            
            Invoke("DolfinTrue", 0.5f);
            

        }

        if (collision.gameObject.tag == "BaseBall2")
        {
            animator.Play("Dolfin Damaged");
            BaseBall2.SetActive(false);
            
            Invoke("DolfinTrue2", 0.5f);
        }

        if (collision.gameObject.tag == "BaseBall3")
        {
            DolfinFinished = true;
            animator.Play("Dolfin Died");
            BaseBall3.SetActive(false);
            Invoke("DolfinDied", 2.7f);
        }

    }

    public void DolfinTrue()
    {
        BaseBall2.SetActive(true);
        script3.Dolfin = true;
        
        
    }

    public void DolfinTrue2()
    {
        Uni.SetActive(true);
        script3.Dolfin = true;


    }
    public void DolfinDied()
    {
        script3.script.Check = false;
        script3.script2.Check = false;
        script3.animator.Play("Kangaroo Move");
        script3.speed = 3.9f;
        //this.gameObject.SetActive(false);
        this.gameObject.transform.position += new Vector3(0, 0, 0.6f);
        Lake.SetActive(true);
    }

    





}
