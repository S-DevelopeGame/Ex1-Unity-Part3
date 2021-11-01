using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [Tooltip("the Transfrom of the player object")]
    [SerializeField] private Transform playerTransform;
    [Tooltip("offset value to the temporary camera x position")]
    [SerializeField] private float offset;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // we store current camera's position in variable temp - temporary position
        Vector3 temp = transform.position;

        // we set the camera's position x to be equal to the player's position x
        temp.x = playerTransform.position.x;

        // add the offset value to the temporary camera x position
        temp.x += offset;

        // change the position of camera
        if(playerTransform.position.x < 5.5-offset && playerTransform.position.x > -5.5 + offset)
            transform.position = temp;

    }
}
