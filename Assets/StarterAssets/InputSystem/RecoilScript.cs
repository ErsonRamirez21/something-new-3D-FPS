using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecoilScript : MonoBehaviour
{
    public GameObject Gun;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Check if shoot button pressed
        if(Input.GetMouseButtonDown(0)) {
            StartCoroutine(StartRecoil());
        }
    }

    IEnumerator StartRecoil() {
        Gun.GetComponent<Animator>().Play("recoil");
        yield return new WaitForSeconds(0.20f);
        Gun.GetComponent<Animator>().Play("New State");
    }

}
