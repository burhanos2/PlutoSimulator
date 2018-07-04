using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit_game : MonoBehaviour
{
    float Stime;

    Scene scene;
    public GameObject playername;
    public GameObject playername2;
	// Use this for initialization
	void Start () {

        BulletSpawner.BulletCount = 0;
        BulletSpawner.shootable = true;
        Planet_lives.enemy_dead = false;
        
        scene = SceneManager.GetActiveScene();

        // putting this in for 1P support
        if (SelectorHandler.select == 0)
        {
            Destroy(GameObject.FindGameObjectWithTag("PlutoPlayer2"));
            Destroy(playername);
            Destroy(playername2);
        }
        //1P support
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        { 
          Stime += Time.deltaTime;
        }
            
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            Stime = 0f;
        }

        if (Stime >= 2.0f)
        {
            if (scene.name == "Lvl1" || scene.name == "Next level")
            {
                SceneManager.LoadScene("Main Menu");
            }
        
            else
            {
                Application.Quit();
            }
            
        }
    }
}
