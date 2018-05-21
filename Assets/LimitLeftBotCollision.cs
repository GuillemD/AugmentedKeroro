using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitLeftBotCollision : MonoBehaviour {

    GameManager gm = null;

    // Use this for initialization
    void Start()
    {

        gm = GameObject.Find("GameManager").GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            gm.red_points += 100;
            Destroy(other.gameObject);
        }
    }
}
