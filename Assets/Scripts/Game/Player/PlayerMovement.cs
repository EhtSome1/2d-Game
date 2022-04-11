using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;

    public Rigidbody2D Rb;

    public SpriteRenderer Sp;

    public float speed;

    public float velocity;

    bool isGrounded;
    bool canDoubleJump;
    public bool pushingRock = false;

    public Transform groundCheck;
    public LayerMask groundlayer;

    public float jumpForce;

    playerHealth Health;

    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();

        Sp = GetComponent<SpriteRenderer>();

        Health = GetComponent<playerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("isGrounded", isGrounded);

        velocity = Rb.velocity.x;

        if (Health.currentHealth > 0)
        {
            isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundlayer);

            float x = Input.GetAxis("Horizontal");
            float moveBy = x * speed;
            Rb.velocity = new Vector2(moveBy, Rb.velocity.y);

            animator.SetFloat("Speed", Mathf.Abs(moveBy));
            if (isGrounded == false)
            {
                animator.SetFloat("JumpSpeed", Rb.velocity.y);
            }
            if (isGrounded)
            {
                animator.SetFloat("JumpSpeed", 0);
            }

            if (Rb.velocity.x < -0.1f)
            {
                Sp.flipX = true;
            }
            else if (Rb.velocity.x > 0.1f)
            {
                Sp.flipX = false;
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (isGrounded)
                {
                    Jump();
                    canDoubleJump = true;
                }
                else if (canDoubleJump)
                {
                    Jump();
                    animator.SetBool("DoubleJump", true);
                    canDoubleJump = false; 
                }
            }
            if (Rb.velocity.y < 0.1)
            {
                animator.SetBool("DoubleJump", false);
            }

            if (pushingRock && Rb.velocity.x < -0.1 || Rb.velocity.x > 0.1)
            {
                animator.SetBool("PushingRock", true);
            }
            if (pushingRock == false)
            {
                animator.SetBool("PushingRock", false);
            }
        }
        
    }
    
    void Jump ()
    {
        Rb.velocity = Vector2.up * jumpForce;
    }
}
