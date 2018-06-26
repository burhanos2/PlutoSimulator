using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : PlayerMovement
{
    public AudioSource shoot_sound;
    public Transform firePoint;
    public GameObject Bullet;

    public static bool shootable = true;
    public static int BulletCount= 0;
	// Use this for initialization
	void Start () {
        shoot();
    }



    void shoot()
    {
        //if (Input.GetKey(KeyCode.Space))
        //{
            if (shootable == true)
            {
                Instantiate(Bullet, firePoint.position, firePoint.rotation);
                BulletCount += 1;
                shoot_sound.Play();
            }
        //}
             Invoke("shoot", 0.1f);    
    }


    // Update is called once per frame
    void Update() {
        
        if (BulletCount >= 3)
        { shootable = false; }

        if (shootable == false && BulletCount <= 2 && Planet_lives.enemy_dead == false)
        {
            shootable = true;
        }
        

    }
}
