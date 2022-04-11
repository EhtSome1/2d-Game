using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public AudioSource hitaudio;

    PlayerMovement movement;

    public int maxHealth = 5;
    public int currentHealth = 5;
    public int life = 3;

    bool canspawn = true;
    bool canTakeDamage = true;
    public bool savepointActive = false;

    public Rigidbody2D Rb;

    public Animator animator;

    LayerMask enemyMask;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log(collision.gameObject.name);
        if (collision.gameObject.layer == 8 && canTakeDamage)
        {
            canTakeDamage = false;

            //Debug.Log(collision.gameObject.tag);


            if (collision.gameObject.tag == "Log")
            {
                currentHealth -= 5;
            }
            else
            {
                currentHealth--;
            }

            animator.SetBool("Hit", true);

            hitaudio.Play();

            Invoke("noHit", 0.3f);

            Invoke("canDamage", 1.5f);

            if (movement.Sp.flipX == true)
            {
                Rb.AddForce(new Vector2(transform.position.x + 700, transform.position.y + 300));
            }
            if (movement.Sp.flipX == false)
            {
                Rb.AddForce(new Vector2(transform.position.x - 700, transform.position.y + 300));
            }
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        enemyMask = LayerMask.GetMask("Enemy");

        movement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0 && canspawn == true)
        {
            animator.SetBool("Dead", true);

            Invoke("respawn", 1f);

            Debug.Log("health is 0");

            canspawn = false;
        }


        if (GetComponent<Transform>().position.y < -17)
        {
            respawn();
        }

        if (canspawn == false)
            Invoke("canSpawn", 3f);

        if (life == 0)
        {
            canspawn = false;
            GameOver();
        }
    }

    void respawn()
    {
        animator.SetBool("Dead", false);
        if (savepointActive ==false)
        {
            GetComponent<Transform>().position = new Vector2(-6.74f, -2.4f);
        }
        if (savepointActive)
        {
            GetComponent<Transform>().position = new Vector2(104.9f, 18.68f);
        }
        currentHealth = maxHealth;
        life--;

        Debug.Log("Respawn");
    }

    void noHit()
    {
        animator.SetBool("Hit", false);
    }

    void canSpawn()
    {
        canspawn = true;
    }
    void canDamage()
    {
        canTakeDamage = true;
    }

    void GameOver()
    {
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("gameOver");
    }
}
