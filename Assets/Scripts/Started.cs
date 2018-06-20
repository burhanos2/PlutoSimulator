using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Started : MonoBehaviour {
    public AudioSource press_bleep;
    // Use this for initialization

    public float animationspeed = 0f;
	void Start () {
        press_bleep.Play();
        GetComponent<Animator>().speed = animationspeed;
	}
	
	// Update is called once per frame
	void Update() {
		
	}
}
