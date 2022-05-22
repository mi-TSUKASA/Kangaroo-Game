using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BeginnerCourseStart()
    {
        SceneManager.LoadScene("Beginner Course");
        GameObject.Find("BGM1").GetComponent<AudioScript>().GetComponent<AudioSource>().enabled = false;   
    }

    public void IntermediateCourseStart()
    {
        SceneManager.LoadScene("Intermediate Course");//中級コーススタート
        GameObject.Find("BGM1").GetComponent<AudioScript>().GetComponent<AudioSource>().enabled = false;
    }

    public void AdvancedCourseStart()
    {
        SceneManager.LoadScene("Advanced Course");//上級コース
        GameObject.Find("BGM1").GetComponent<AudioScript>().GetComponent<AudioSource>().enabled = false;
    }

    public void BeginnerCourseSelect()
    {
        SceneManager.LoadScene("Beginner Course Select");//初級コース
    }

    public void IntermediateCourseSelect()
    {
        SceneManager.LoadScene("Intermediate Course Select");//中級コース
    }

    public void AdvancedcourseSelect()
    {
        SceneManager.LoadScene("Advanced Course Select");//上級コース
    }
}
