using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public static bool playerCanMove = true;
    public float jumpForce = 10f; // The force applied to make the player jump
    public float movementSpeed = 2f;
    public float jumpDelay = 0.5f; // The time delay between jumps
    private Rigidbody2D rb; // The rigidbody component of the player
    private Animator anim;
    private Quaternion rot;
    private Vector2 plamov;
    private float lastJumpTime; // The time of the player's last jump

    void Start()
    {
        anim = GetComponent<Animator>();
        rot = transform.rotation;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (playerCanMove)
        {
            if (Input.GetKeyDown(KeyCode.Space) && Time.time - lastJumpTime >= jumpDelay)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                lastJumpTime = Time.time; // Update the last jump time
            }

            plamov = transform.position;

            float posupdate = Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed;

            if (posupdate == 0)
            {
                anim.enabled = false;
            }
            else
            {
                anim.enabled = true;
            }

            if (posupdate < 0)
            {
                rot.y = 180;
                transform.rotation = rot;
            }
            else
            {
                rot.y = 0;
                transform.rotation = rot;
            }

            plamov.x += posupdate;
            transform.position = plamov;
        }
    }
}
