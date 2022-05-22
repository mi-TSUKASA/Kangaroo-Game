using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearScript2 : MonoBehaviour
{
    public float speed;
  
    //public GameObject Clear;
    //public ClearScript script;
    
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false); 
        
        //script = Clear.GetComponent<ClearScript>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Kangaroo3")
        {
            SceneManager.LoadScene("LoseScene3");
            
        }
    }

    
}
