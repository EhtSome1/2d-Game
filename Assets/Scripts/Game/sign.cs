using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sign : MonoBehaviour
{
    public GameObject signtext;

    public AudioSource audio;
    void Start()
    {
        signtext.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        signtext.SetActive(true);
        audio.Play();
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        signtext.SetActive(false);
        audio.Stop();
    }
}
