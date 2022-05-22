using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class StageSelectScript : MonoBehaviour
{
    public GameObject BeginnerSecret;
    public GameObject BeginnerClear;
    int stageNumber;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        stageNumber = PlayerPrefs.GetInt("stageNumber");

        if (stageNumber == 0)
        {
            BeginnerSecret.SetActive(true); 
        }

        if (stageNumber >= 1)
        {
            
            BeginnerClear.SetActive(true);
        }


    }
}
