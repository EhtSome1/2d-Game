using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logMove : MonoBehaviour
{

    public float rotatespeed;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Rb.rotation += 1f;
        transform.localEulerAngles = new Vector3(0, 0, Mathf.PingPong(Time.time * rotatespeed, 90) - 45);
    }
}
