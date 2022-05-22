using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TopButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TopButton()
    {
        SceneManager.LoadScene("Start Scene");
        GameObject.Find("BGM1").GetComponent<AudioScript>().GetComponent<AudioSource>().enabled = true;
    }

    public void TopButton2()
    {
        SceneManager.LoadScene("Start Scene");
        Time.timeScale = 1;
        GameObject.Find("BGM1").GetComponent<AudioScript>().GetComponent<AudioSource>().enabled = true;
    }
}
