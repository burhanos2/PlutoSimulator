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
    private int hp = 5;
    public Image Hearts;
    // Use this for initialization
    void Start () {
        InvokeRepeating("DestroyAtTime", 5.0f, 10.0f);
        randomdirection = Random.Range(Random.Range(0.70f , 1.50f), 0.01f);
       
    }

    // Update is called once per frame
    void Update () {
        transform.position = new Vector3(transform.position.x - 0.5f, transform.position.y - randomdirection, transform.position.z);
        player = GameObject.Find("PlutoPlayer");
            m_SpriteRenderer = player.GetComponent<SpriteRenderer>();
            
    }
    private void DestroyAtTime()
    {
       
        Destroy(this.gameObject);
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "PlutoPlayer")
        {   
            Destroy(this.gameObject);
            GameObject thePlayer = GameObject.Find("PlutoPlayer");
            PlayerMovement playerScript = thePlayer.GetComponent<PlayerMovement>();
            playerScript.leventjes = playerScript.leventjes - 1;
            GameObject.Find("Hearts").GetComponent<Animator>().SetInteger("levens", playerScript.leventjes);
            m_SpriteRenderer.color = Color.red;
            player.GetComponent<PlayerMovement>().geraakt();
        }
        if (collision.gameObject.name == "Defence(Clone)")
        {

            Destroy(this.gameObject);
        }
    }
 }
