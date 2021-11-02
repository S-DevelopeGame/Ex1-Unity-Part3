using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer2 : MonoBehaviour
{
    [Tooltip("speed movement of the object")]
    [SerializeField] private float speed;
    private Vector3 movement;
    [Tooltip("the Animator of the player")]
    [SerializeField] private Animator animator;

    private bool rightFace; // the player is looking to the right
    private float oldSpeed = 0; // save the speed of the player
    // Start is called before the first frame update
    void Start()
    {
        rightFace = true;
        oldSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.W) || (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.A)))
        {
            animator.SetBool("isWalking", false);
        }
        if (Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A) && transform.position.x < 10.300)
        {
            transform.position += Vector3.right * Time.deltaTime * speed;
            animator.SetBool("isWalking", true);
        }
        else if (Input.GetKey(KeyCode.W) && transform.position.y < -0.6)
        {
            transform.position += Vector3.up * Time.deltaTime * speed;
            animator.SetBool("isWalking", true);
        }
        else if (Input.GetKey(KeyCode.S) && transform.position.y > -4.2)
        {
            transform.position += Vector3.down * Time.deltaTime * speed;
            animator.SetBool("isWalking", true);
        }
        else if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D) && transform.position.x > -10.300)
        {
            transform.position += Vector3.left * Time.deltaTime * speed;
            animator.SetBool("isWalking", true);
        }



        if (!rightFace && Input.GetKeyDown(KeyCode.D) && !Input.GetKey(KeyCode.A))
        {
            rightFace = true;
            transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
        }
        else if (rightFace && Input.GetKeyDown(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            rightFace = false;
            transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
        }




    }
}
