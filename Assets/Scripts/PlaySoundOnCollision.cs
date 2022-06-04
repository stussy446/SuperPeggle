using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(GetComponent<AudioSource>())
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
