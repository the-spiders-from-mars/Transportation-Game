using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    private float init_x, init_y, init_z;

	// Use this for initialization
	void Start () {
		init_x = transform.localPosition.x;
        init_y = transform.localPosition.y;
        init_z = transform.localPosition.z;
        
    }
	
	// Update is called once per frame
	void Update () {
        float pos_x = transform.localPosition.x + 0.01f * init_x;
        float pos_y = transform.localPosition.y + 0.01f * init_y;
        float pos_z = transform.localPosition.z + 0.01f * init_z;

        float rot_x = transform.rotation.x + 0.001f;
        float rot_y = transform.rotation.y + 0.001f;
        transform.localPosition = new Vector3(pos_x, pos_y, pos_z);
        //transform.localRotation = Quaternion.LookRotation(new Vector3(rot_x, rot_y, 0));
        transform.Rotate(new Vector3(0,0.2f,0) * 0.1f);
    }
}
