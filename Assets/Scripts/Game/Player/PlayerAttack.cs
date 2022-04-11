using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Animator animator;

    MushroomHealth Mushroom;

    flyHealth fly;

    goblinHealth goblinH;

    PlayerMovement move;

    float attackWay;

    public AudioSource audio;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        move = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (move.Sp.flipX == false)
        {
            attackWay = 0.5f;
        }
        if (move.Sp.flipX == true)
        {
            attackWay = -0.5f;
        }

        if (Input.GetKeyDown(KeyCode.M) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            animator.SetBool("Attack", true);

            audio.Play();

            Invoke("StopAttack", 0.1f);

            Vector2 posRight = new Vector2(transform.position.x + attackWay, transform.position.y);
            Collider2D[] colliders = Physics2D.OverlapBoxAll(posRight, new Vector2(0.8f, 1f), 0f);
            foreach (Collider2D collision in colliders)
            {
                switch (collision.gameObject.tag)
                {
                    case "Mushroom":
                        Mushroom = collision.gameObject.GetComponent<MushroomHealth>();
                        Debug.Log("Hit ze mushroom!");
                        Mushroom.hit = true;
                        break;
                    case "Fly":
                        fly = collision.gameObject.GetComponent<flyHealth>();
                        Debug.Log("Hit ze fly");
                        fly.hit = true;
                        break;
                    case "Goblin":
                        goblinH = collision.gameObject.GetComponent<goblinHealth>();
                        Debug.Log("Hit ze goblin!");
                        goblinH.hit = true;
                        break;
                    default:
                        Debug.Log("Hit inte");
                        break;
                }
            }
        }
    }
    void StopAttack()
    {
        animator.SetBool("Attack", false);
    }

   /* private void OnDrawGizmos()
    {
        Vector2 posRight = new Vector2(transform.position.x + attackWay, transform.position.y);
        Gizmos.DrawCube(posRight, new Vector3(0.8f, 1f, 0));
    }*/
}
