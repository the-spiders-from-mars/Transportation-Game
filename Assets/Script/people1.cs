﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class people1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider collision){
		Destroy (this.gameObject);
	}
}
