using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class space_UI : MonoBehaviour {
   public float x;
   public float y;
   public float z;
    bool up = false;
    bool down = true;
   public float plus;

    public float high;
    public float low;

	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update () 
{
        transform.position = new Vector3(x, y, z);

        // if its above the low point push it down
        if ( y > low && down == true)
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
