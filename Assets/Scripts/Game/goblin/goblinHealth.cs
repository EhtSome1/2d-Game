using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goblinHealth : MonoBehaviour
{
    public Animator animator;

    public AudioSource hitSound;

    int health = 3;

    public bool hit = false;

    // Update is called once per frame
    void Update()
    {
        if (hit)
        {
            animator.SetBool("Hit", true);
            Invoke("noHit", 0.1f);
            health--;

            hitSound.Play();

            hit = false;
        }
        if (health <= 0)
        {
            animator.SetBool("Dead", true);
            Invoke("death", 0.4f);
        }
    }

    void death()
    {
        Destroy(gameObject);
    }

    void noHit()
    {
        animator.SetBool("Hit", false);
    }
}
