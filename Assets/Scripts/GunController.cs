using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour {

    public float richting;
    

	// Use this for initialization
	void Start () {
        richting = GameObject.Find("PlutoPlayer").transform.localEulerAngles.z;

    }

    // Update is called once per frame
    void Update()
    {

        if (richting == 180)
        { 
        transform.position = new Vector3(transform.position.x + 1f, transform.position.y, transform.position.z);

        }

        else if (richting == 0 || richting == 360)
        {

            transform.position = new Vector3(transform.position.x - 1f, transform.position.y, transform.position.z);
        }

        else if (richting == 270)
        {

            transform.position = new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z);
        }

        else if (richting == 90)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 1f, transform.position.z);
        }


        
    }
}
