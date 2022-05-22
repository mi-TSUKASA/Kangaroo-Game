using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggScript : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Egg", 0);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
    }

    void Egg()
    {
        speed = 4;
    }
}
