using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;
public class BaseBallScript3 : MonoBehaviour
{
    public float speed;
    public float hitspeed;
    public GameObject Kangaroo;
    public KangarooScript2 script3;
    public GameObject OutVideo;
    VideoPlayer videoPlayer;
    AudioSource audioSource;
    public AudioClip sound1;
    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = OutVideo.GetComponent<VideoPlayer>();
        Kangaroo = GameObject.Find("Kangaroo");
        script3 = Kangaroo.GetComponent<KangarooScript2>();
        Invoke("DolfinThrow", 2.1f);
        Invoke("DolfinThrow2", 2.5f);
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        this.transform.position -= new Vector3(hitspeed * Time.deltaTime, 0, 0);

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        
            if (collision.gameObject.tag == "Punch")
            {
                speed = 0;
                hitspeed = -20;
             }

            if (collision.gameObject.tag == "Kangaroo2")
            {
                SceneManager.LoadScene("LoseScene2");
            }

        if (collision.gameObject.tag == "UniChecker")
        {
            
            Invoke("OutScene", 0.5f);
            Invoke("LoseScene2", 3f);
            audioSource.PlayOneShot(sound1);
        }


    }

    public void DolfinThrow()
    {
        this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
        this.gameObject.GetComponent<BoxCollider2D>().enabled = true;
        speed = 10;
        script3.Dolfin = false;
        

    }
    public void DolfinThrow2()
    {
        this.tag = "BaseBall2";
    }

    public void LoseScene2()
    {
        SceneManager.LoadScene("LoseScene2");
    }

    public void OutScene()
    {
        OutVideo.GetComponent<RawImage>().enabled = true;
        OutVideo.GetComponent<VideoPlayer>().enabled = true;
        videoPlayer.Play();
    }
}
