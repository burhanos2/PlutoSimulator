using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class space_UI : MonoBehaviour {
   public float x;
   public float y;
   public float z;
    bool up = false;
    bool down = true;


   public static float plus = 0.01f;

    public float high;
    public float low;



    // Use this for initialization
    void Start ()
    {
        transform.position = new Vector3(x, y, z);
    }
	
	// Update is called once per frame
	void Update () 
{

        bool Planspeed = Planet_lives.speed;
 
        Scene scene = SceneManager.GetActiveScene();

        if (scene.name == "Main Menu")
        {
            plus = 0.01f;
        }

        // not being executed
        else if (Planspeed == false && scene.name == "Lvl1")
        {
            plus = 0f;
        }

        else if (Planspeed == true && scene.name == "Lvl1")
        {
            plus = 0.05f;
        }

        transform.position = new Vector3(x, y, z);

        // if its above the low point push it down
        if ( y > low && down == true )
        {
            y -= plus;
        }
        // if it is below the low point or the low point make down false
        else if ( y <= low && down == true)
        {
            down = false;
            up = true;
        }


        // if its below the high point push it up
        if (y < high && up == true)
        {
            y += plus;
        }
        // if it is the high point or higher make up false
        else if (y >= high && up == true)
        {
            up = false;
            down = true;
        }
    }
}
