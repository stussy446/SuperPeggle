using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScoreOnCollision : MonoBehaviour
{
    public UIController uIController;
    public int scoreToAdd;

    private void Start()
    {
        uIController = FindObjectOfType<UIController>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("pickup"))
        {
            uIController.AddScore(scoreToAdd);
            Destroy(collision.gameObject);

        }
    }

}
