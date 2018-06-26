using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Astroïde_rij : MonoBehaviour
{

    SpriteRenderer m_SpriteRenderer;
    SpriteRenderer m_SpriteRenderer2;
    public GameObject player;
    public GameObject player2;
    public float speed = 0.1f;
    private bool hits = false;

    public Image Hearts;
    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, 2f);  

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x - 0.39f, transform.position.y, transform.position.z);
        player = GameObject.FindWithTag("PlutoPlayer");
        player2 = GameObject.FindWithTag("PlutoPlayer2");
        m_SpriteRenderer = player.GetComponent<SpriteRenderer>();
        m_SpriteRenderer2 = player2.GetComponent<SpriteRenderer>();
    }
    private void DestroyAtTime()
    {

        Destroy(this.gameObject);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "PlutoPlayer" && hits == false  || collision.gameObject.tag == "PlutoPlayer2" && hits == false)
        {


            GameObject thePlayer = GameObject.FindGameObjectWithTag("PlutoPlayer");
            PlayerMovement playerScript = thePlayer.GetComponent<PlayerMovement>();
            playerScript.leventjes -= 1;
            GameObject.Find("Hearts").GetComponent<Animator>().SetInteger("levens", playerScript.leventjes);
            m_SpriteRenderer.color = Color.red;
            m_SpriteRenderer2.color = Color.red;
            player.GetComponent<PlayerMovement>().geraakt();
            hits = true;
            if (hits)
            {
                GameObject hitsound = GameObject.FindGameObjectWithTag("soundhit");
                Getting_hit hitScri = hitsound.GetComponent<Getting_hit>();
                hitScri.Get_hit.Play();
            }
            Destroy(this.gameObject);
        }
        if (collision.gameObject.name == "Defence(Clone)")
        {
            Destroy(this.gameObject);
        }
    }
}