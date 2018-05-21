using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBallCollision : MonoBehaviour {

    GameManager gm = null;
    
	// Use this for initialization
	void Start () {

        gm = GameObject.Find("GameManager").GetComponent<GameManager>();

        gm.blue_lifes = 3;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            gm.blue_lifes -= 1;
            Destroy(other.gameObject);

            if (gm.blue_lifes == 2)
            {
                gm.life_blue_3.SetActive(false);
            }
            if(gm.blue_lifes == 1)
            {
                gm.life_blue_2.SetActive(false);
            }
            if(gm.blue_lifes == 0)
            {
                gm.life_blue_1.SetActive(false);
            }
            
        }
    }
}
