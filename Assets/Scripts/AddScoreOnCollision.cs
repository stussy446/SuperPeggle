using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScoreOnCollision : MonoBehaviour
{
    public UIController uIController;
    public int scoreToAdd;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        uIController.AddScore(scoreToAdd);
    }
}
