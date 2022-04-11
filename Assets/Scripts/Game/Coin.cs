using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public Animator animator;

    public AudioSource sound;

    public GameObject uiMan;

    UImanager UI;

    public int coinAmount = 0;

    private void Start()
    {
        UI = uiMan.GetComponent<UImanager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            animator.SetBool("PickedUp", true);
            Debug.Log("added the coin");
            UI.CoinAmount += 1;
            Debug.Log("Picked up ze goin!");
            Invoke("destroy", 0.35f);

            sound.Play();
        }
    }

    void destroy()
    { 
        Destroy(gameObject);
    }
}
