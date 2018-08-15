using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.W)){
            anim.Play("Walking Cycle");
        }
        if (Input.GetKeyDown(KeyCode.W) && Input.GetKeyDown(KeyCode.LeftShift))
        {
            anim.Play("Run Cycle");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.Play("Jump Cycle");
        }



    }
}

