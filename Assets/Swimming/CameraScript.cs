using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

    public float WaterHeight;
   

    // Use this for initialization
    void Start () {
        RenderSettings.fog = false;
	}
	
	// Update is called once per frame
	void Update () {
		
        if (transform.position.y <= WaterHeight)
        {
            RenderSettings.fog = true;
        }
        else
        {
            RenderSettings.fog = false;
        }
	}
}
