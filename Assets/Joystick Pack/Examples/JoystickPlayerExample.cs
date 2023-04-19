﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour
{
    public float speed;
    public DynamicJoystick dynamicJoystick;
    public Rigidbody rb;
    private Animator animator;
    

    private void Start()
    {
        GetComponent<Animator>();
        
    }

    public void FixedUpdate()
    {
        Vector3 direction = Vector3.forward * dynamicJoystick.Vertical + Vector3.right * dynamicJoystick.Horizontal;
        rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);

        if (this.GetComponent<Rigidbody>().velocity.magnitude > 1 )
        {
            animator.SetBool("isWalking", true);

        }
    }
}