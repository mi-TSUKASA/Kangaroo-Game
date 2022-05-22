using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class StageSelectScript2 : MonoBehaviour
{
    public GameObject IntermediateSecret;
    public GameObject IntermediateClear;
    public Button button;
    int stageNumber;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        stageNumber = PlayerPrefs.GetInt("stageNumber");

        if (stageNumber >= 1)
        {
            button.GetComponent<Button>().interactable = true;
        }

        if (stageNumber <= 1)
        {
            IntermediateSecret.SetActive(true);
            
        }

        if (stageNumber >= 2)
        {

            IntermediateClear.SetActive(true);
            
        }


    }
}
