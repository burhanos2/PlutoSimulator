using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appear : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Renderer>().enabled = true;
    }
	
    
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = new Vector3(0.46f, -0.09f, 0);
            gameObject.GetComponent<Renderer>().enabled = true;
        }
	}
}
