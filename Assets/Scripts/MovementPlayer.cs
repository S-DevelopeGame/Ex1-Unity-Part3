using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    [Tooltip("speed movement of the object")]
    [SerializeField] private float speed;
    [SerializeField] private Animator animator;
    private bool rightFace = true;
    private float oldSpeed = 0;
    // Start is called before the first frame update
    void Start()
    {
        rightFace = true;
        oldSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.UpArrow) || (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.LeftArrow)))
        {
            animator.SetBool("isWalking", false);
        }
        if (Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.LeftArrow) && transform.position.x < 10.300)
        {
            transform.position += Vector3.right * Time.deltaTime * speed;
            animator.SetBool("isWalking", true);
        }
        else if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < -0.6)
        {
            transform.position += Vector3.up * Time.deltaTime * speed;
            animator.SetBool("isWalking", true);
        }
        else if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > -4.2)
        {
            transform.position += Vector3.down * Time.deltaTime * speed;
            animator.SetBool("isWalking", true);
        }
        else if (Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow) && transform.position.x > -10.300)
        {
            transform.position += Vector3.left * Time.deltaTime * speed;
            animator.SetBool("isWalking", true);
        }



        if (!rightFace && Input.GetKeyDown(KeyCode.RightArrow) && !Input.GetKey(KeyCode.LeftArrow))
        {
            rightFace = true;
            transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
        }
        else if (rightFace && Input.GetKeyDown(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow))
        {
            rightFace = false;
            transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
        }



    }
}
