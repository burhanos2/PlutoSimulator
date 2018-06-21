using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Planet_lives : MonoBehaviour
{
    Collider2D m_collider;
    public AudioSource Neptune_hit;
    public static bool speed = true;

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
        m_collider = GetComponent<Collider2D>();
    }
    
    
    void ToWin()
    {
        SceneManager.LoadScene("Next Level");
    }

	// Update is called once per frame
	void FixedUpdate()
    {
        healthDisplay.text = "Health: " + BOOM;
        if (BOOM <= 0)
        {
            speed = false;
            Invoke("ToWin", 5);
            gameObject.GetComponent<Renderer>().enabled = false;
            m_collider.enabled = false;
            BOOM = 0;
        }
    }
}
