using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text ballText;

    private int score;

    public void SetNumBalls(int numBalls)
    {
        ballText.text = "BALLS: " + numBalls;
    }

    public void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "SCORE: " + score;
    }
}
