﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GobackNow : MonoBehaviour {

    // Use this for initialization
   

    void Start()
    {
       
       StartCoroutine ( Wait());
       
    }

    IEnumerator Wait()
    {
        
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Main Menu");

    }

	
	// Update is called once per frame
	void Update() {
	
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Main Menu");
        }
	}
}
