using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyHealth : MonoBehaviour
{
    public int health = 1;

    public AudioSource hitSound;

    public bool hit = false;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (hit)
        {
            health--;

            animator.SetBool("dead", true);

            hitSound.Play();

            Invoke("death", 0.5f);
        }
    }

    void death()
    {
        Destroy(gameObject);
    }
}
