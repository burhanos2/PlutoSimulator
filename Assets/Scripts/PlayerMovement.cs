using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {
    public float speed;
    private float normalspeed;
    private bool rightUp;
    private bool leftUp;
    private bool collisionwall = false;
    public  int leventjes = 5;
    private bool jetpackaan;

    SpriteRenderer m_SpriteRenderer;
    public GameObject player;
    // Use this for initialization
    void Start () {
        normalspeed = 50;
        speed = speed * -1;
        
    }
	
	// Update is called once per frame
	void Update () {
    
        if (leventjes <= 0)
        {
            SceneManager.LoadScene("Death");
        }



        if (Input.GetKey("left") && rightUp == false)
        {
            leftUp = true;
            

            GameObject.Find("Jetpack").GetComponent<Animator>().SetBool("aan", jetpackaan);

            Vector3 temp = transform.rotation.eulerAngles;
            temp.z = 0.0f;
            transform.rotation = Quaternion.Euler(temp);
                if(collisionwall == true)
            {
                var x = Input.GetAxis("Horizontal") * Time.deltaTime * normalspeed;
                transform.Translate(x - 2f, 0, 0);
                collisionwall = false;
            }
            else {
            var x = Input.GetAxis("Horizontal") * Time.deltaTime * normalspeed;
            transform.Translate(x, 0, 0);
            }
            

        }
        if (Input.GetKeyUp("left"))
        {

            leftUp = false;
    }
        if (Input.GetKey("right") && leftUp == false)
        {
           
            if (collisionwall == false)
            {
                

                rightUp = true;
                var x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
                transform.Translate(x, 0, 0);
                Vector3 temp = transform.rotation.eulerAngles;
                temp.z = 180.0f;
                transform.rotation = Quaternion.Euler(temp);
                
            }
            else
            {
               
            }
        }
        if (Input.GetKeyUp("right"))
        {

            rightUp = false;
        }

        if (Input.GetKey("up") && rightUp == false && leftUp == false)
        {
            var UpDown = Input.GetAxis("Vertical") * Time.deltaTime * speed;
            transform.Translate(UpDown, 0, 0);
            Vector3 temp = transform.rotation.eulerAngles;
            temp.z = 270.0f;
            transform.rotation = Quaternion.Euler(temp);
            GameObject.Find("Jetpack").GetComponent<Animator>().SetBool("aan", jetpackaan);

        }
        if (Input.GetKey("down") && rightUp == false && leftUp == false)
        {
            var UpDown = Input.GetAxis("Vertical") * Time.deltaTime * normalspeed;
            transform.Translate(UpDown, 0, 0);
            Vector3 temp = transform.rotation.eulerAngles;
            temp.z = 90.0f;
            transform.rotation = Quaternion.Euler(temp);
            GameObject.Find("Jetpack").GetComponent<Animator>().SetBool("aan", jetpackaan);
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "wall")
        {
          
            collisionwall = true;
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
