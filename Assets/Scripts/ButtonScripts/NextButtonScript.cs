using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextButton()
    {
        SceneManager.LoadScene("Intermediate Course");
    }

    public void NextButton2()
    {
        SceneManager.LoadScene("Advanced Course");
    }
}
