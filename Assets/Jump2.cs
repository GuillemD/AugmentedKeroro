using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump2 : MonoBehaviour {

    private GameObject redBall = null;

    private Vector3 verticalForce = new Vector3(0, 1, 0);


    private bool redJump;

    public float thrust;

    private void Start()
    {

        redBall = GameObject.FindGameObjectWithTag("Redball");


        redJump = false;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("TriggerRight"))
        {
            if (!redJump)
            {
                if (redBall.GetComponent<Transform>().position.y < -1.1)
                {
                    redJump = true;
                    redBall.GetComponent<Rigidbody>().velocity = Vector3.up * thrust;
                }

            }


        }
    }


    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("TriggerRight"))
        {
            
                if (redJump)
                {
                    redJump = false;

                }
            

        }

    }
}
