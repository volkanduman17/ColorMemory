using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public DynamicJoystick dynamicJoystick;
    public Rigidbody rb;
    public Animator animator;

    private void Start()
    {
        //animator=GetComponent<Animator>();
    }

    public void FixedUpdate()
    {
        Vector3 direction = Vector3.forward * dynamicJoystick.Vertical + Vector3.right * dynamicJoystick.Horizontal;
        // rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
        rb.velocity = direction * speed * Time.fixedDeltaTime;

        if (direction.magnitude > 0.1f)
        {
            animator.SetBool("isWalking", true);
            transform.LookAt(rb.position + direction);
        }
        else
        {
            animator.SetBool("isWalking", false);
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;        }
    }
}