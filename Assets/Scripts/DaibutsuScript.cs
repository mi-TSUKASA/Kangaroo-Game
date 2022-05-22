using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaibutsuScript : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Daibutsu", 19.4f);
        //Invoke("Daibutsu2", 23f);
        Invoke("Daibutsu2", 27f);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
    }

    void Daibutsu()
    {
        speed = 2.3f;
    }

    void Daibutsu2()
    {
        speed = -2;
    }

}
