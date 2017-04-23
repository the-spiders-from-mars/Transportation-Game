using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Vehicles.Car
{
	public class people : MonoBehaviour {

		// Use this for initialization
		void Start () {

		}

		// Update is called once per frame
		void Update () {

		}
		void OnTriggerEnter(Collider collision){
			if (!Money.isOccupied) {
				Destroy (this.gameObject);
				Money.isOccupied = true;
			}
		}
	}
}

