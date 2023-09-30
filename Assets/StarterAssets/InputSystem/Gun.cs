using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets; 

public class NewBehaviourScript : MonoBehaviour
{
    private StarterAssetsInputs _input;
    [SerializeField]
    private GameObject bulletPrefab; 
    [SerializeField]
    private GameObject bulletPoint; 
    [SerializeField]
    private float bulletSpeed = 600;
    public AudioClip soundEffect; 

    // Start is called before the first frame update
    void Start()
    {
        _input = transform.root.GetComponent<StarterAssetsInputs>();

    }

    // Update is called once per frame
    void Update(){
        if(_input.shoot){
            Shoot();
            _input.shoot = false;
        }
    }

    void Shoot() {
        AudioSource.PlayClipAtPoint (soundEffect, transform.position);
        GameObject bullet = Instantiate(bulletPrefab, bulletPoint.transform.position, transform.rotation);
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed);
        Destroy(bullet, 1);
    }
}
