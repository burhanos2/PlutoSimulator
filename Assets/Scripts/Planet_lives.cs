using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Planet_lives : MonoBehaviour
{
    public Slider slider;

    public GameObject effect;
    int DO_IT = 1;
    public Quaternion rotation = Quaternion.identity;

    float timer;
    int maxboom;

    public static bool enemy_dead = false;

    Collider2D m_collider;
    public Collider2D player1col;
    public Collider2D player2col;

    public AudioSource Neptune_hit;
    public static bool speed = true;

    public int BOOM;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            timer = 0;
            BOOM -=1;
            Neptune_hit.Play();
        }
    }
    // Use this for initialization
    void Start()
    {
        if (SelectorHandler.select == 0)
        {
            BOOM = 350;
            maxboom = 350;
            slider.maxValue = maxboom;
        }
        else if (SelectorHandler.select == 1)
        {
            BOOM = 500;
            maxboom = 500;
            slider.maxValue = maxboom;
        }

        m_collider = GetComponent<Collider2D>();

        m_collider.enabled = true;
        player1col.enabled = true;
        if (player2col != null)
        { 
        player2col.enabled = true;
        }
    }
    
    
    void ToWin()
    {
        SceneManager.LoadScene("Next Level");
    }

    

	// Update is called once per frame
	void FixedUpdate()
    {

        slider.value = BOOM;

        if (slider.value <= 0)
        { slider.value = 0; }

        timer += Time.deltaTime;
        //if (Input.GetKeyDown(KeyCode.P))
        //{
        //    BOOM = 10;
        //    PlayerPrefs.SetInt("Highscore", 0);
        //}

        Vector3 pos = new Vector3(transform.position.x - 0.1f, transform.position.y - 0.1f, transform.position.z);
        rotation.eulerAngles = new Vector3(0, 0, 0);

        
        if (BOOM <= 0)
        {
            speed = false;
            Invoke("ToWin", 5); 
            gameObject.GetComponent<Renderer>().enabled = false;
            m_collider.enabled = false;
            player1col.enabled = false;
            if (player2col != null)
            {
                player2col.enabled = false;
            }
            BOOM = 0;
            enemy_dead = true;
            BulletSpawner.shootable = false;

            if (DO_IT == 1)
            {
                DO_IT -= 1;
                Instantiate(effect, pos, rotation);

            }


        }

        if(BOOM < maxboom && timer >= 2.0f)
        {
            timer -= 0.5f;
            BOOM += 1;
        }

    }
}
