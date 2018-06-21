using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {
    public bool Movement;
    public  int leventjes = 5; 
    private bool jetpackaan;

    public static bool Died = false;
    SpriteRenderer m_SpriteRenderer;
    private Rigidbody2D force;
    public GameObject player;
    // Use this for initialization
    void Start () {
        force = GetComponent<Rigidbody2D>();
    }
	
    void Die()
    {
         SceneManager.LoadScene("Death");
    }

	// Update is called once per frame
	void Update()
    {
        if (leventjes <= 0)
        {
            Invoke("Die", 5);
            Movement = false;
            Died = true;
        }




        if (Input.GetKey(KeyCode.RightArrow) && Movement == true)
        {
            force.velocity = new Vector3(25, 0, 0);

        }
        else if (Input.GetKey(KeyCode.LeftArrow) && Movement == true)
        {
            force.velocity = new Vector3(-25, 0, 0);
        }
        else if (Input.GetKey(KeyCode.UpArrow) && Movement == true)
        {
            force.velocity = new Vector3(0, 25, 0);
        }
        else if  (Input.GetKey(KeyCode.DownArrow) && Movement == true)
        {
            force.velocity = new Vector3(0, -25, 0);
        }
        else
        {
            force.velocity = new Vector3(0, 0, 0);
        }



    }
    IEnumerator Example()
    {

        player = GameObject.Find("PlutoPlayer");
        m_SpriteRenderer = player.GetComponent<SpriteRenderer>();

        yield return new WaitForSeconds(1);
        m_SpriteRenderer.color = Color.white;
    }
    public void geraakt()
    {
        StartCoroutine(Example());
    }
}
