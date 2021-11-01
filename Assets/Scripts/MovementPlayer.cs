using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    [Tooltip("speed movement of the object")]
    [SerializeField] private float speed;
    private Vector3 movement;
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
        

        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * Time.deltaTime * speed;
            animator.SetBool("isWalking", true);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * Time.deltaTime * speed;
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }

        if(!rightFace && Input.GetKeyDown(KeyCode.RightArrow))
        {
            rightFace = true;
            transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
        }
            
        else if(rightFace && Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rightFace = false;
            transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
        }
          






        if (transform.position.x < -10.300 && !rightFace || transform.position.x > 10.300 && rightFace)
        {
            speed = 0;
        }
        else
        {
            speed = oldSpeed;
        }



    }
}
