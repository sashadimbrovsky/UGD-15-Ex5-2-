﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(false);

        }

    }





            // Use this for initialization
            void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
