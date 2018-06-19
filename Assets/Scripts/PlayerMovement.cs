using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {
    //public float speedLeft = -3;
    //public float speedRight = -20;
    //public float speedUp = 3;
    //public float speedDown = 20;
    public  int leventjes = 5;
    private bool jetpackaan;

    SpriteRenderer m_SpriteRenderer;
    private Rigidbody2D force;
    public GameObject player;
    // Use this for initialization
    void Start () {
        force = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update()
    {
        if (leventjes <= 0)
        {
            SceneManager.LoadScene("Death");
        }


        if (Input.GetKey(KeyCode.RightArrow))
        {
            force.velocity = new Vector3(25, 0, 0);

        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            force.velocity = new Vector3(-25, 0, 0);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            force.velocity = new Vector3(0, 25, 0);
        }
        else if  (Input.GetKey(KeyCode.DownArrow))
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
