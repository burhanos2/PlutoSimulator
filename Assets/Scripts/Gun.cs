﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : PlayerMovement {

    public Transform firePoint;
    public GameObject Bullet;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

       

        if (Input.GetKeyDown (KeyCode.Space))
        {
            Instantiate(Bullet, firePoint.position, firePoint.rotation);

            

        }
        

    }
}
