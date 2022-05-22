using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class UFOVideoScript: MonoBehaviour
{
    VideoPlayer videoPlayer;
  
    // Start is called before the first frame update
    void Start()
    {
        
        videoPlayer = this.gameObject.GetComponent<VideoPlayer>();
        
    }

    // Update is called once per frame
    void Update()
    {   
            Invoke("UFOVideo", 8.2f);    
    }

    public void UFOVideo()
    {
        
        
        this.gameObject.GetComponent<RawImage>().enabled = true;
        this.gameObject.GetComponent<VideoPlayer>().enabled = true;
        videoPlayer.Play();
        Invoke("UFOFinish", 2.9f);


    }

    public void UFOFinish()
    {
        Destroy(this.gameObject);
    }

}
