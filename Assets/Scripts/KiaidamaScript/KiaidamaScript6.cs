using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KiaidamaScript6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
        Invoke("Kiaidama", 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Kiaidama()
    {
        this.gameObject.SetActive(true);
    }
}
