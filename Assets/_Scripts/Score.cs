using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public int totalScore;

    public int highScore;
    public Text highScoreText;


    public static int scoreMultiplier;
    public Text scoreMultiplierText;
    public static int Bonus;
    public Text bonusT;

    private void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore");

        if (PlayerPrefs.HasKey("scMulti"))
        {
            scoreMultiplier = PlayerPrefs.GetInt("scMulti");
        }
        else
        {
            scoreMultiplier = 1;
        }
        
        Bonus = scoreMultiplier * 2;
    }

    private void Update()
    {
        if(highScore < totalScore)
        {
            highScore = totalScore;
            
            PlayerPrefs.SetInt("HighScore", highScore);
        }

        highScoreText.text = highScore.ToString();
        scoreMultiplierText.text = "x" + scoreMultiplier.ToString();
        bonusT.text = Bonus.ToString();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        totalScore += scoreMultiplier;
        scoreText.text = totalScore.ToString();
    }
}
