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
	void Update () {
		if(Input.GetKey (KeyCode.W))
        {
            anim.Play("walking");
        }
       else
        {
           
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
        {
            anim.Play("running");
        }
        else
        {
            
        }
    }
}
