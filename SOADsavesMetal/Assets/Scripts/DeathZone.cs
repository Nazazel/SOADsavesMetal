﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.tag == "Player")
        {
            coll.gameObject.GetComponent<Player>().dead = true;
        }
    }
}