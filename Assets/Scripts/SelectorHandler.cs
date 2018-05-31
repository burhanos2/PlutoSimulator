using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectorHandler : MonoBehaviour {
    private int select;
    public AudioSource select_beep;
  
 
    // Update is called once per frame
    void Update ()
    {
	   if (Input.GetKeyDown (KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            select -= 1;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            select += 1;
        }
        

        //////////
    
        if(select == -1)
        {
            select = 1;
        }

        if(select == 2)
        {
            select = 0;
        }

        /////////////////

            if(select == 0)
            {
                if (this.transform.position != new Vector3(0.01f, 2.94f, 0))
                {
                transform.position = new Vector3(0.01f, 2.94f, 0);
                select_beep.Play();
                }
            }

            if(select == 1)
            {
                if (this.transform.position != new Vector3(-0.05f, -0.92f, 0))
                {
                transform.position = new Vector3(-0.05f, -0.92f, 0);
                select_beep.Play();
                }
            }

            //////////////////////////////////////////
            

        if (Input.GetKeyDown (KeyCode.X))
        {

            
            
            if (select == 0)
            {
                // go to game
                
                SceneManager.LoadScene("Lvl1");
            }


            else
            {
                //credits
                
                SceneManager.LoadScene("Credits");
            }

        }

        

    }

    
    
}
