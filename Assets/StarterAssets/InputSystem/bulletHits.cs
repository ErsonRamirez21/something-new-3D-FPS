using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletHits : MonoBehaviour
{
    private int dead = 0; 
    public AudioClip deathClip;

    private void OnTriggerEnter(Collider other)
    {
        if (dead == 0 && other.gameObject.tag == "bullet")
        {
            Debug.Log("Bullet has hit me");
            GetComponent<Animator>().Play("pushed");
            dead = 1;
            AudioSource.PlayClipAtPoint (deathClip, transform.position);
            ScoreManager.instance.AddPoint();
            GameEnd.instance.subtractEnemy();
        }
    }
}

