using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death_pluto : MonoBehaviour {


    // THIS SECTION IS DEATH ANIMATIONS
    public float animationspeed = 0f;
    void Start()
    {
        GetComponent<Animator>().speed = animationspeed;
    }

    public void ChildKill()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Destroy(transform.GetChild(i).gameObject, 0.1f);
        }
    }



    // Update is called once per frame
    void Update () {
		if (Input.GetKeyDown (KeyCode.K))
        {
            ChildKill();
        }
	}
}
