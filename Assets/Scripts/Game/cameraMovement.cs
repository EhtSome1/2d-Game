using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    public Transform playerTransform;

    private Transform Transform;
    // Start is called before the first frame update
    void Start()
    {
        Transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Transform.position = new Vector3(playerTransform.position.x, playerTransform.position.y, -10f);
    }
}
