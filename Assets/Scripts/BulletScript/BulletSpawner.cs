using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : PlayerMovement
{
    public AudioSource shoot_sound;
    public Transform firePoint;
    public GameObject Bullet;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

       

      //  if (Input.GetKeyDown (KeyCode.Space))

        if(Input.GetKeyDown (KeyCode.X))
        {
            Instantiate(Bullet, firePoint.position, firePoint.rotation);
            shoot_sound.Play();
        }
        

    }
}
