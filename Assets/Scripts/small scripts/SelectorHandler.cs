using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectorHandler : MonoBehaviour {
    //private int select;
   //  public AudioSource select_beep;
  
 
    // Update is called once per frame
    void Update()
    {
	   //if (Input.GetKeyDown (KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.UpArrow))
    //    {
    //        select -= 1;
    //    }

    //    if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.DownArrow))
    //    {
    //        select += 1;
    //    }
        

        //////////
    
        //if(select == -1)
        //{
        //    select = 1;
        //}

        //if(select == 2)
        //{
        //    select = 0;
        //}

        /////////////////

            //if(select == 0)
            //{
            //    if (this.transform.position != new Vector3(0.02f, 1.06f, 0))
            //    {
            //    transform.position = new Vector3(0.02f, 1.06f, 0);
            //    select_beep.Play();
            //    this.transform.localScale = new Vector3 (1.243593f, 1.243593f, 1.243593f);
            //    }
            //}

            //if(select == 1)
            //{
            //    if (this.transform.position != new Vector3(7.412f, -4.111f, 0))
            //    {
            //    transform.position = new Vector3(7.412f, -4.111f, 0);
            //    select_beep.Play();
            //    this.transform.localScale = new Vector3(0.547661f, 0.5417605f, 1);
            //}
            //}

            //////////////////////////////////////////
            

        if (Input.GetKeyDown (KeyCode.Space))
        {

            
            
            //if (select == 0)
            //{
                // go to game
                
                SceneManager.LoadScene("Lvl1");
            //}


            //else
            //{
            //    //credits
                
            //    SceneManager.LoadScene("Credits");
            //}

        }

        

    }

    
    
}
