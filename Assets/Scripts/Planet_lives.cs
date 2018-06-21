using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Planet_lives : MonoBehaviour
{
    public AudioSource Neptune_hit;

    public int BOOM;
    public Text healthDisplay;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            BOOM -=1;
            Neptune_hit.Play();
        }
    }
    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void FixedUpdate()
    {
        healthDisplay.text = "Health: " + BOOM;
        if (BOOM <= 0)
        {
            SceneManager.LoadScene("Next Level");
        }
    }
}
