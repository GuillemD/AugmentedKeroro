using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;
    public int blue_lifes = 3;
    public int red_lifes = 3;

    public GameObject life_blue_1;
    public GameObject life_blue_2;
    public GameObject life_blue_3;

    public GameObject life_red_1;
    public GameObject life_red_2;
    public GameObject life_red_3;




    public int blue_points = 0;
    public int red_points = 0;


    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

       
	}
    // Use this for initialization
    void Start() {

         blue_lifes = 3;
         red_lifes = 3;

       // life_blue_1 = GameObject.Find("Life_1");
       // life_blue_2 = GameObject.Find("Life_2");
       // life_blue_3 = GameObject.Find("Life_3");
        life_blue_1.SetActive(true);
        life_blue_2.SetActive(true);
        life_blue_3.SetActive(true);

        life_red_1.SetActive(true);
        life_red_2.SetActive(true);
        life_red_3.SetActive(true);
    }
    // Update is called once per frame
    void Update () {
        if(red_lifes == 0 )
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            ResetValues();
        }

        if(blue_lifes == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            ResetValues();
        }
       
	}
    void ResetValues()
    {
        red_lifes = 3;
        blue_lifes = 3;
    }
   
}
