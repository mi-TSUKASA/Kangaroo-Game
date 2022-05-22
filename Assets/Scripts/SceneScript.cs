using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Scene", 0.2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Scene()
    {
        this.gameObject.SetActive(false);
    }
}
