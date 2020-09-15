using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(SphereCollider))]

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 10f;
    public float maxVelocityChange = 10.0f;

    public float forwardForce = 100f;
    public float sideWaysForce = 25f;
    private Vector3 movement;

    void Awake()
    {
        rb.freezeRotation = true;
        rb.useGravity = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float xMove = Input.GetAxis("Horizontal");
        float zMove = Input.GetAxis("Vertical");

        movement = new Vector3(xMove, 0f, zMove);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        movement = transform.TransformDirection(movement);
        movement *= speed;

        Movement(movement);
    }

    void Movement(Vector3 direction)
    {
        Vector3 velocity = rb.velocity;
        Vector3 velocityChange = (movement - velocity);
        velocityChange.x = Mathf.Clamp(velocityChange.x, -maxVelocityChange, maxVelocityChange);
        velocityChange.z = Mathf.Clamp(velocityChange.z, -maxVelocityChange, maxVelocityChange);
        velocityChange.y = 0;

        rb.AddForce(velocityChange, ForceMode.VelocityChange);
    }
}
