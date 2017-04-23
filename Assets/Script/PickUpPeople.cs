using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpPeople : MonoBehaviour {

	public bool isOccupied = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void onTriggerEnter(Collider collision){
		if (collision.gameObject.tag == "Passenger") {
			if (!isOccupied) {
				Destroy (collision.gameObject);
				isOccupied = true;
			}
		}
	}
}
