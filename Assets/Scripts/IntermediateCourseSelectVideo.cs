using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class IntermediateCourseSelectVideo : MonoBehaviour
{
    
    public VideoClip NewvideoClip;
    public VideoPlayer videoPlayerComponent;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("IntermediateCourseSelect", 2.1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IntermediateCourseSelect()
    {
        videoPlayerComponent.clip = NewvideoClip;
    }
}
