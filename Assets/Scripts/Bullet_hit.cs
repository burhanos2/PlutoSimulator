using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet_hit : BulletController
{
    public int BOOM;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            DestroyObject(Bullet);
            BOOM +=1;
            print(BOOM);
        }
    }
    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update()
    {
        if (BOOM >= 400)
        {
            SceneManager.LoadScene("Next Level");
        }
    }
}
