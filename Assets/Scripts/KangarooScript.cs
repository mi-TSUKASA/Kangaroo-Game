using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KangarooScript : MonoBehaviour
{
    
    public float speed;
    public GameObject jumpButton;
    public ButtonScript script;
    int stageNum =0;


    // Start is called before the first frame update
    void Start()
    {
        jumpButton = GameObject.Find("ButtonLeft");
        script = jumpButton.GetComponent<ButtonScript>();
        

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += new Vector3(speed*Time.deltaTime,0,0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            SceneManager.LoadScene("LoseScene");
        }

        if (collision.gameObject.tag == "GOAL")
        {
            stageNum = 1;
            SceneManager.LoadScene("WinScene");
            PlayerPrefs.SetInt("stageNumber", stageNum);
            
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
