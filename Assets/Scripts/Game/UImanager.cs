using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UImanager : MonoBehaviour
{
    //health icons
    public GameObject health1;
    public GameObject health2;
    public GameObject health3;
    public GameObject health4;
    public GameObject health5;

    //life icons
    public GameObject life1;
    public GameObject life2;
    public GameObject life3;

    //coin icons
    public GameObject coin1;
    public GameObject coin2;
    public GameObject coin3;
    public GameObject coin4;
    public GameObject coin5;

    public GameObject player;

    playerHealth playerhealth;

    public int CoinAmount = 0;

    // Start is called before the first frame update
    void Start()
    {
        playerhealth = player.GetComponent<playerHealth>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (playerhealth.currentHealth == 5)
        {
            health1.SetActive(true);
            health2.SetActive(true);
            health3.SetActive(true);
            health4.SetActive(true);
            health5.SetActive(true);
        }
        if (playerhealth.currentHealth == 4)
        {
            health1.SetActive(true);
            health2.SetActive(true);
            health3.SetActive(true);
            health4.SetActive(true);
            health5.SetActive(false);
        }
        if (playerhealth.currentHealth == 3)
        {
            health1.SetActive(true);
            health2.SetActive(true);
            health3.SetActive(true);
            health4.SetActive(false);
            health5.SetActive(false);
        }
        if (playerhealth.currentHealth == 2)
        {
            health1.SetActive(true);
            health2.SetActive(true);
            health3.SetActive(false);
            health4.SetActive(false);
            health5.SetActive(false);
        }
        if (playerhealth.currentHealth == 1)
        {
            health1.SetActive(true);
            health2.SetActive(false);
            health3.SetActive(false);
            health4.SetActive(false);
            health5.SetActive(false);
        }
        if (playerhealth.currentHealth <= 0)
        {
            health1.SetActive(false);
            health2.SetActive(false);
            health3.SetActive(false);
            health4.SetActive(false);
            health5.SetActive(false);
        }

        if (playerhealth.life == 3)
        {
            life1.SetActive(true);
            life2.SetActive(true);
            life3.SetActive(true);
        }
        if (playerhealth.life == 2)
        {
            life1.SetActive(true);
            life2.SetActive(true);
            life3.SetActive(false);
        }
        if (playerhealth.life == 1)
        {
            life1.SetActive(true);
            life2.SetActive(false);
            life3.SetActive(false);
        }
        if (playerhealth.life <= 0)
        {
            life1.SetActive(false);
            life2.SetActive(false);
            life3.SetActive(false);
        }

        if (CoinAmount == 1)
        {
            coin1.SetActive(true);
        }
        if (CoinAmount == 2)
        {
            coin2.SetActive(true);
        }
        if (CoinAmount == 3)
        {
            coin3.SetActive(true);
        }
        if (CoinAmount == 4)
        {
            coin4.SetActive(true);
        }
        if (CoinAmount == 5)
        {
            coin5.SetActive(true);
        }
    }
}
