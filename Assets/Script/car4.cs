﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car4 : MonoBehaviour {

	float speed=0.1f;
	double aroundDis=2;

	//	Vector3[] v=initpage.Vector;

	Vector3[] v=new Vector3[8];

	int i=0;
	// Use this for initialization
	void Start () {
		//select the beginning and end randomly
		//then according to djkstra get the vectors
		v[0] = new Vector3 (-3, -1, 6);
		v[1] = new Vector3 (-3, -1, 73);
		v[2] = new Vector3 (-3, -1, 133);
		v[3] = new Vector3 (27, -1, 133);
		v[4] = new Vector3 (62, -1, 133);
		v[5] = new Vector3 (62, -1, 62);
		v[6] = new Vector3 (62, -1, 6);
		v[7] = new Vector3 (30, -1, 6);

		transform.localPosition = v[0];
	}

	int getDirection(Vector3 v0,Vector3 v1){
		if (v0.z == v1.z && v0.x < v1.x)
			return 0;
		else if(v0.z == v1.z && v0.x > v1.x)
			return 1;
		if (v0.z < v1.z && v0.x == v1.x)
			return 2;
		else if(v0.z > v1.z && v0.x == v1.x)
			return 3;
		return -1;
	}

	void turnAround(){
		//left
		//right
		transform.Rotate(Vector3.up * (4.5f));
	}


	// Update is called once per frame
	void Update () {
		int di;
		Vector3 v0, v1, v2;
		v0 = v [i];
		if (i == v.Length - 2) {
			v1 = v [i+1];
			v2 = v [0];
			di = getDirection (v0, v1);
		} else if (i == v.Length - 1) {
			v1 = v [0];
			v2 = v [1];
			di = getDirection (v0, v1);
		} else {
			v1=v[i+1];
			v2=v[i+2];
			di = getDirection (v0, v1);
		}
		double temp ;
		if (di == 0||di==1) {
			if (di == 0) {
				temp = v1.x - transform.localPosition.x;
				if(temp>=0&&temp<=aroundDis&&v1.x==v2.x){
					//turn around from x to z
					turnAround();
				}
				transform.localPosition = new Vector3 (transform.localPosition.x + speed, transform.localPosition.y, transform.localPosition.z);
				if (transform.localPosition.x >= v1.x) {
					if (i == v.Length - 1)
						i = 0;
					else
						i++;
				}
			} else {
				temp = transform.localPosition.x-v1.x;
				if(temp>=0&&temp<=aroundDis&&v1.x==v2.x){
					//turn around from x to z
					turnAround();
				}
				transform.localPosition = new Vector3 (transform.localPosition.x - speed, transform.localPosition.y, transform.localPosition.z);
				if (transform.localPosition.x <= v1.x) {
					if (i == v.Length - 1)
						i = 0;
					else
						i++;
				}
			}
		} else {
			if(di==2){
				temp = v1.z-transform.localPosition.z;
				if(temp>=0&&temp<=aroundDis&&v1.z==v2.z){
					//turn around
					turnAround();
				}
				transform.localPosition=new Vector3(transform.localPosition.x,transform.localPosition.y,transform.localPosition.z+speed);
				if (transform.localPosition.z >= v1.z) {
					if (i == v.Length - 1)
						i = 0;
					else
						i++;
				}
			}else{
				temp = transform.localPosition.z-v1.z;
				if(temp>=0&&temp<=aroundDis&&v1.z==v2.z){
					//turn around
					turnAround();
				}
				transform.localPosition=new Vector3(transform.localPosition.x,transform.localPosition.y,transform.localPosition.z-speed);
				if (transform.localPosition.z <= v1.z) {
					if (i == v.Length - 1)
						i = 0;
					else
						i++;
				}
			}
		}
	}
}
