using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AstroïdeMovement : MonoBehaviour
{
    SpriteRenderer m_SpriteRenderer;
     SpriteRenderer m_SpriteRenderer2;
        
    public GameObject player;
    public GameObject player2;
    public float speed = 0.1f;
    private float randomdirection;
    public Image Hearts;
    private bool hits = false;


    // Use this for initialization
    void Start () {
        randomdirection = Random.Range(Random.Range(0.70f , 1.50f), 0.01f);
        Destroy(gameObject, 7.5f);

        player = GameObject.FindWithTag("PlutoPlayer");
        player2 = GameObject.FindWithTag("PlutoPlayer2");
        if(player2 != null)
        {
            m_SpriteRenderer2 = player2.GetComponent<SpriteRenderer>();
           
        }
         
        m_SpriteRenderer = player.GetComponent<SpriteRenderer>();
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x - 0.15f, transform.position.y - randomdirection, transform.position.z);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "PlutoPlayer" && hits == false|| collision.gameObject.tag == "PlutoPlayer2" && hits == false)
        {
            
            
            GameObject thePlayer = GameObject.FindGameObjectWithTag("PlutoPlayer");
            PlayerMovement playerScript = thePlayer.GetComponent<PlayerMovement>();
            playerScript.leventjes -=1;
            GameObject.Find("Hearts").GetComponent<Animator>().SetInteger("levens", playerScript.leventjes);
            m_SpriteRenderer.color = Color.red;
            if (player2 != null)
            {
                m_SpriteRenderer2.color = Color.red;
            }
            player.GetComponent<PlayerMovement>().geraakt();
            //if (player2 != null)
            //{
            //    player2.GetComponent<PlayerMovement>().geraakt();
            //}
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
