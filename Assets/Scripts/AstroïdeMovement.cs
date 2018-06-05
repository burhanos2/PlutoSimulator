using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AstroïdeMovement : MonoBehaviour
{
    SpriteRenderer m_SpriteRenderer;
    public GameObject player;
    public float speed = 0.1f;
    private float randomdirection;
    public Image Hearts;
    private bool hits = false;

    // Use this for initialization
    void Start () {
        InvokeRepeating("DestroyAtTime", 5.0f, 10.0f);
        randomdirection = Random.Range(Random.Range(0.70f , 1.50f), 0.01f);
       
    }

    // Update is called once per frame
    void Update ()
    {
        transform.position = new Vector3(transform.position.x - 0.5f, transform.position.y - randomdirection, transform.position.z);
        player = GameObject.Find("PlutoPlayer");
            m_SpriteRenderer = player.GetComponent<SpriteRenderer>();
          
       
    }
    private void DestroyAtTime()
    {
       
        Destroy(this.gameObject);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "PlutoPlayer" && hits == false)
        {
            
            
            GameObject thePlayer = GameObject.FindGameObjectWithTag("PlutoPlayer");
            PlayerMovement playerScript = thePlayer.GetComponent<PlayerMovement>();
            playerScript.leventjes -=1;
            GameObject.Find("Hearts").GetComponent<Animator>().SetInteger("levens", playerScript.leventjes);
            m_SpriteRenderer.color = Color.red;
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
