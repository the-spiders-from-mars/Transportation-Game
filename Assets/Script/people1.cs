﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Vehicles.Car
{
	public class people1 : MonoBehaviour {

		public bool isOccupied = false;

		// Use this for initialization
		void Start () {

		}

		// Update is called once per frame
		void Update () {

		}
		void OnTriggerEnter(Collider collision){
			if (!isOccupied) {
				Destroy (this.gameObject);
				isOccupied = true;
			}
		}
	}
}

