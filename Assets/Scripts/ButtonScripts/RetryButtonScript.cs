using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RetryButtonScript : MonoBehaviour
{
    
    
    
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }

   

    public void RetryButton1()
    {
        SceneManager.LoadScene("Beginner Course");
    }

    public void RetryButton2()
    {
        SceneManager.LoadScene("Intermediate Course");
    }

    public void RetryButton3()
    {
        SceneManager.LoadScene("Advanced Course");
    }

}
