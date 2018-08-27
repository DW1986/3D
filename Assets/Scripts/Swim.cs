using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swim : MonoBehaviour {

    public float Speed;
    public float JumpPower;
    public float Gravity;

    public float WaterHeight;

    public float WSpeed, WJumpPower, WGravity;

    [SerializeField]
    private bool _inWater;

    private CharacterController _cc;

    private Vector3 _moveDirection = Vector3.zero;

    // Use this for initialization
	void Start ()
    {
        _cc = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (transform.position.y <= WaterHeight)
        {
            _inWater = true;
        }
        else
        {
            _inWater = false;
        }
        if (!_inWater)
        {
            if (_cc.isGrounded)
            {

          
                    _moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
                    _moveDirection = transform.TransformDirection(_moveDirection);
                    _moveDirection *= Speed;

                    if (Input.GetButton("Jump"))
                        _moveDirection.y = JumpPower;
            }
            _moveDirection.y -= Gravity * Time.deltaTime;
            _cc.Move(_moveDirection * Time.deltaTime);


        }
        else
        {
            _moveDirection = new Vector3(Input.GetAxis("Horizontal"), -WGravity * Time.deltaTime, Input.GetAxis("Vertical"));
            _moveDirection = transform.TransformDirection(_moveDirection);
            _moveDirection *= WSpeed;

            if (Input.GetButton("Jump"))
                _moveDirection.y = WJumpPower;
       
         _cc.Move(_moveDirection * Time.deltaTime);
    }
	}
}
