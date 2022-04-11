using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator animator;

    public GameObject door;

    bool doorup = false;

    public AudioSource closeSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && doorup == false)
        {
            door.SetActive(true);

            doorup = true;

            closeSound.Play();

            animator.SetBool("DoorUp", true);

            Invoke("doorIdle", 0.5f);
        }
    }


    void doorIdle()
    {
        animator.SetBool("DoorUp", false);
    }
}
