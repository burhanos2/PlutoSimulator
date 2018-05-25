using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Astroïde_rij : MonoBehaviour
{

    SpriteRenderer m_SpriteRenderer;
    public GameObject player;
    public float speed = 0.1f;
  
    private int hp = 5;
    public Image Hearts;
    // Use this for initialization
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x - 0.5f, transform.position.y, transform.position.z);
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
