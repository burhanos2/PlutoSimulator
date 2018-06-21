using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_delete : MonoBehaviour
{
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy"|| collision.gameObject.name == "Defence(Clone)")
        {
            
            Destroy(gameObject);
        }


        
    }
}
   