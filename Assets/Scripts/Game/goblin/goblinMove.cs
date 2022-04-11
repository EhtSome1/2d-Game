using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goblinMove : MonoBehaviour
{
    public bool canmove = false;

    public Animator animator;

    public Transform player;

    public float speed;

    public float agroRange;

    public Rigidbody2D Rb;

    public SpriteRenderer Sp;

    public float velocity;

    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();

        Sp = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float distToPlayer = Vector2.Distance(transform.position, player.position);

        if (distToPlayer < agroRange)
        {
            ChasePlayer();
        }
        else
        {
            StopChasingPlayer();
        }

        animator.SetFloat("speed", Rb.velocity.x);
    }

    void ChasePlayer()
    {
        if (transform.position.x < player.position.x)
        {
            Rb.velocity = new Vector2(speed, 0);

            Sp.flipX = false;
        }
        else
        {
            Rb.velocity = new Vector2(-speed, 0);

            Sp.flipX = true;
        }
    }

    void StopChasingPlayer()
    {
        Rb.velocity = new Vector2(0, 0);
    }
}
