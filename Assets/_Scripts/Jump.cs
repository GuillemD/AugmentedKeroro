using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

    private GameObject blueBall = null;

    private Vector3 verticalForce = new Vector3(0, 1, 0);


    private bool blueJump;

    public float thrust;

    private void Start()
    {

        blueBall = GameObject.FindGameObjectWithTag("BlueBall");


        blueJump = false;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("TriggerLeft"))
        {
            if (!blueJump)
            {
                if(blueBall.GetComponent<Transform>().position.y < 0.3 )
                {
                    blueJump = true;
                    blueBall.GetComponent<Rigidbody>().velocity = Vector3.up * thrust;
                }
                

            }


        }
    }

    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("TriggerLeft"))
        {
            
             if (blueJump)
             {
                 blueJump = false;

             }
            
            
        }
       
    }

}
