using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death_neptune : MonoBehaviour {


    // THIS SECTION IS DEATH ANIMATIONS
    public float animationspeed = 0f;
    void Start()
    {
        GetComponent<Animator>().speed = animationspeed;
    }



    // Update is called once per frame
    void Update () {
		
	}
}
