using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit_game : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// putting this in for 1P support
        if (SelectorHandler.select == 0)
        {
            Destroy(GameObject.FindGameObjectWithTag("PlutoPlayer2"));
        }

        //1P support
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }
}
