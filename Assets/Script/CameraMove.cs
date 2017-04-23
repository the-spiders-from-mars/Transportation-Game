using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    private float init_x, init_y, init_z;

	// Use this for initialization
	void Start () {
		init_x = transform.position.x;
        init_y = transform.position.y;
        init_z = transform.position.z;
        
    }
	
	// Update is called once per frame
	void Update () {
        float pos_y = transform.position.y * 0.998f;
        transform.position = new Vector3(init_x, pos_y, init_z);
    }
}
