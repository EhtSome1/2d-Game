using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    PlayerMovement PlayerScript;

    Rigidbody2D Rb;

    public GameObject Player;

    void Start()
    {
        PlayerScript = Player.gameObject.GetComponent<PlayerMovement>();

        Rb = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (Rb.velocity.x > 0.1 || Rb.velocity.x < 0.1)
            {
                PlayerScript.pushingRock = true;
            }

        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
         PlayerScript.pushingRock = false;

    }
}
