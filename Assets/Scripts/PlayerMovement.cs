using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {
    public bool Movement;
    public  int leventjes = 5; 
    private bool jetpackaan;

    public KeyCode Up;
    public KeyCode Down;
    public KeyCode Left;
    public KeyCode Right;

    public static bool Died = false;
    SpriteRenderer m_SpriteRenderer;
    SpriteRenderer m_SpriteRenderer2;
    private Rigidbody2D force;
    public GameObject player;
    public GameObject player2;
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




        if (Input.GetKey(Right) && Movement == true)
        {
            force.velocity = new Vector3(25, 0, 0);

        }
        else if (Input.GetKey(Left) && Movement == true)
        {
            force.velocity = new Vector3(-25, 0, 0);
        }
        else if (Input.GetKey(Up) && Movement == true)
        {
            force.velocity = new Vector3(0, 25, 0);
        }
        else if  (Input.GetKey(Down) && Movement == true)
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

        player = GameObject.FindWithTag("PlutoPlayer");
        player2 = GameObject.FindWithTag("PlutoPlayer2");
        m_SpriteRenderer = player.GetComponent<SpriteRenderer>();
        m_SpriteRenderer2 = player2.GetComponent<SpriteRenderer>();

        yield return new WaitForSeconds(1);
        m_SpriteRenderer.color = Color.white;
        m_SpriteRenderer2.color = Color.white;
    }
    public void geraakt()
    {
        StartCoroutine(Example());
    }
}
