using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyscript : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag ("Player")) {
            PlayerController.haveKey = true;
            gameObject.SetActive (false);
            print ("key picked");

        }

    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
