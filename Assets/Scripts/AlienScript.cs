using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienScript : MonoBehaviour
{
    public GameObject Beam;
    Animator animator;
    Animator BeamAnimaor;
    // Start is called before the first frame update
    void Start()
    {
        animator = this.gameObject.GetComponent<Animator>();
        BeamAnimaor = Beam.GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        Invoke("AlienAnimation", 14.3f);
        Invoke("BeamAnimation", 14.4f);
    }

    void AlienAnimation()
    {
        animator.Play("Alien Animation");
        
    }
    void BeamAnimation()
    {
        BeamAnimaor.Play("Beam Animation");
    }
}
