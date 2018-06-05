using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {
    public float speedLeft = -3;
    public float speedRight = -20;
    public float speedUp = 3;
    public float speedDown = 20;
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
	void Update () {
        if (leventjes <= 0)
        {
            SceneManager.LoadScene("Death");
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            force.AddForce(transform.right * speedRight);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            force.AddForce(transform.right * speedLeft);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            force.AddForce(transform.up * speedUp);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            force.AddForce(transform.up * speedDown);
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
