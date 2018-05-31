using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    public float rotation;
    

	// Use this for initialization
	void Start ()
    {
        rotation = GameObject.Find("PlutoPlayer").transform.localEulerAngles.z;
        

    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 0.8f);

        if (rotation == 180)
        { 
            transform.position = new Vector3(transform.position.x + 1f, transform.position.y, transform.position.z);
        }

        //else if (rotation == 0 || rotation == 360)
        //{
        //    transform.position = new Vector3(transform.position.x - 1f, transform.position.y, transform.position.z);
        //}

        //else if (rotation == 270)
        //{
        //    transform.position = new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z);
        //}

        //else if (rotation == 90)
        //{
        //    transform.position = new Vector3(transform.position.x, transform.position.y - 1f, transform.position.z);
        //}
    }
}
