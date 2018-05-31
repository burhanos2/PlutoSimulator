using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Started : MonoBehaviour {
    public AudioSource press_bleep;
	// Use this for initialization
	void Start () {
        press_bleep.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
