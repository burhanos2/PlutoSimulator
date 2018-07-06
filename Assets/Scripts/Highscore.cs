using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Highscore : MonoBehaviour
{
    public Text Hscore;
    public Text New;
    public Text Score;
    public static float timeS = 10000f;
    int score_int;

    public static bool newscore;
    Scene scene;

    // Use this for initialization
    void Start ()
    {
        Hscore.text = "HIGHSCORE: " + PlayerPrefs.GetInt("Highscore", 0);
    }

    // Update is called once per frame
    void Update()
    {
        scene = SceneManager.GetActiveScene();

        if (scene.name == "Lvl1")
        {
            timeS -= Time.deltaTime;
        }

        Mathf.Round(timeS);
        score_int = (int)timeS;

        Score.text = "SCORE: " + score_int;

        if (Planet_lives.enemy_dead == true && score_int > PlayerPrefs.GetInt("Highscore", 0))
        {
            PlayerPrefs.SetInt("Highscore", score_int);
            Hscore.text = "HIGHSCORE: " + PlayerPrefs.GetInt("Highscore", 0);
            newscore = true;
        }

        if (newscore == false)
        {
            New.text = " ";
        }
        else if (newscore == true)
        {
            New.text = "NEW HIGHSCORE";
        }   
    }
}
