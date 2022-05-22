using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopButtonScript : MonoBehaviour
{
    public GameObject StopButton;
    public GameObject ReStartButton;
    public GameObject PauseScene;
    public GameObject TopButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Stop()
    {
        Time.timeScale = 0;
        StopButton.SetActive(false);
        ReStartButton.SetActive(true);
        PauseScene.SetActive(true);
        TopButton.SetActive(true);

    }

    public void ReStart()
    {
        Time.timeScale = 1;
        StopButton.SetActive(true);
        ReStartButton.SetActive(false);
        PauseScene.SetActive(false);
        TopButton.SetActive(false);
    }
}
