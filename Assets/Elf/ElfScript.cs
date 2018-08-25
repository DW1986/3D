using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElfScript : MonoBehaviour {

    private Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator> ();
	}

    // Update is called once per frame
    void Update()
    {   // walking
        if (Input.GetKeyDown(KeyCode.W) && !Input.GetKeyDown(KeyCode.LeftShift))
        {
            anim.Play("walking");

        }

        if (Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.LeftShift))
        {

          
            anim.SetBool("IsWalking", true);
            anim.SetBool("IsIdle", false);
            anim.SetBool("IsRunning", false);
            anim.SetBool("IsJumping", false);

        }
        else
        {

            anim.SetBool("IsJumping", false);
            anim.SetBool("IsIdle", true);
            anim.SetBool("IsWalking", false);
            anim.SetBool("IsRunning", false);



        }

        // Juming
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.Play("jumping");

        }

        if (Input.GetKey(KeyCode.Space))
        {


            anim.SetBool("IsJumping", true);
            anim.SetBool("IsIdle", false);
            anim.SetBool("IsWalking", false);
            anim.SetBool("IsRunning", false);


        }
        else
        {





        }
        // running
        if (Input.GetKeyDown(KeyCode.W) && Input.GetKeyDown(KeyCode.LeftShift))
        {
            anim.Play("running");

        }

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
        {

           
            anim.SetBool("IsJumping", false);
            anim.SetBool("IsIdle", false);
            anim.SetBool("IsWalking", false);
            anim.SetBool("IsRunning", true);


        }
        else
        {


         


        }
    }
}


