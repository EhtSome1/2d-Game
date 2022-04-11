using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class savepoint : MonoBehaviour
{
    public Animator animator;

    public AudioSource audio;

    playerHealth PH;

    public GameObject Player;

    private void Start()
    {
        PH = Player.gameObject.GetComponent<playerHealth>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && PH.savepointActive == false)
        {
            animator.SetBool("active", true);

            audio.Play();

            PH.savepointActive = true;
        }
    }
}
