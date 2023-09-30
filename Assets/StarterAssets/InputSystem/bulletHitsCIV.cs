using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class bulletHitsCIV : MonoBehaviour
{
    public GameObject hitTextPrefab; // Reference to the Text Prefab

    public AudioClip deathClip;
    private int dead = 0; 

    private void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (dead == 0 && other.gameObject.tag == "bullet")
        {
            Debug.Log("Bullet has hit non enemy");
            AudioSource.PlayClipAtPoint (deathClip, transform.position);
            ScoreManager.instance.SubPoint();
            dead = 1;
            GameObject j = Instantiate(hitTextPrefab, transform.position, Quaternion.identity, transform);
            j.transform.position += Vector3.up*2;
        }
    }
}

