using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBallCollision : MonoBehaviour {

    GameManager gm = null;

    // Use this for initialization
    void Start()
    {

        gm = GameObject.Find("GameManager").GetComponent<GameManager>();

        gm.red_lifes = 3;

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            gm.red_lifes -= 1;
            Destroy(other.gameObject);

            if (gm.red_lifes == 2)
            {
                gm.life_red_3.SetActive(false);
            }
            if (gm.red_lifes == 1)
            {
                gm.life_red_2.SetActive(false);
            }
            if (gm.red_lifes == 0)
            {
                gm.life_red_1.SetActive(false);
            }
         
        }
    }
}
