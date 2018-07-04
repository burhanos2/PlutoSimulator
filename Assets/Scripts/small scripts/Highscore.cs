using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Highscore : MonoBehaviour
{
    public Text Score;
    public static float timeS = 10000f;
    int score_int;

    // Use this for initialization
    void Start ()
    {
	}

    // Update is called once per frame
    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();

        if (scene.name == "Lvl1")
        { 
        timeS -= Time.deltaTime;
        }
        Mathf.Round(timeS);
        score_int = (int)timeS;

        Score.text = "SCORE: " + score_int;
    }
}
