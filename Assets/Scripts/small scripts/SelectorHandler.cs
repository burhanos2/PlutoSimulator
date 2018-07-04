using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectorHandler : MonoBehaviour {
    public static int select;
    public AudioSource select_beep;
    public float x;

    void Start()
    {
        PlayerMovement.Died = false;
        this.transform.localScale = new Vector3(1.243593f, 1.243593f, 1.243593f);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.J))
        {
            select -= 1;
        }

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.L))
        {
            select += 1;
        }


        ////////

        if (select == -1)
        {
            select = 1;
        }

        if (select == 2)
        {
            select = 0;
        }

        ///////////////

        if (select == 0)
        {
            x = -1.297534f;
            if (this.transform.position != new Vector3(x, 0.61f, 0))
            {
                transform.position = new Vector3(x, 0.61f, 0);
                select_beep.Play();
            }
        }

        if (select == 1)
        {
            x = 1.5f;
            if (this.transform.position != new Vector3(x, 0.61f, 0))
            {
                transform.position = new Vector3(x, 0.61f, 0);
                select_beep.Play();
            }
        }

        ////////////////////////////////////////


        if (Input.GetKeyDown (KeyCode.Space))
        {



            if (select == 0)
            {
                //go to game


                SceneManager.LoadScene("Lvl1");
                PlayerMovement.Died = false;
            }


            else
            {
                // kill p2
                SceneManager.LoadScene("Lvl1");
            }

        }

        

    }

    
    
}
