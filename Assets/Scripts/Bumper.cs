using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    public float bounceForce = 200f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 normal = collision.GetContact(0).normal;
        Vector2 force = -normal * bounceForce;

        if( collision.gameObject.GetComponent<Rigidbody2D>() )
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(force);
        }
    }
}
