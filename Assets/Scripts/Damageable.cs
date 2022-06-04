using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageable : MonoBehaviour
{
    public int hitPoints = 1;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        hitPoints--;

        if(hitPoints <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
