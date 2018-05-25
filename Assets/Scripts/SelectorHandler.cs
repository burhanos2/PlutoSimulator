using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectorHandler : MonoBehaviour {
    private int select;

	
	// Update is called once per frame
	void Update ()
    {
	   if (Input.GetKeyDown (KeyCode.LeftArrow))
        {
            select -= 1;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
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

        ////////////

            if(select == 0)
            {
                    transform.position = new Vector3(0, 2.5f, 0);
            }

            if(select == 1)
            {
            transform.position = new Vector3(0, 0, 0);
            }

            //////////////////////////////////////////


        if (Input.GetKeyDown (KeyCode.X))
        {

            if(select == 0)
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
