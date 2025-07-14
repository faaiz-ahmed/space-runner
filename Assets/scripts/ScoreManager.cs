using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private float score;

    public Text highscore;
    void Start()
    {
        highscore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            score += 1 * Time.deltaTime;
            scoreText.text = ((int)score).ToString();

            if (score > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", (int)score);
                highscore.text = score.ToString("0");
            }

        }

    }
}
