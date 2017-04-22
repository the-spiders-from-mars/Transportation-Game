using System;
using UnityEngine;
using UnityEngine.UI;

namespace UnityStandardAssets.Vehicles.Car
{
	public class Money : MonoBehaviour
	{
		public int money = 0;
		bool tag=true;
		void Update(){
			if (CarUserControl.distance0 < 50 && tag == true) {
				money += 50;
				tag = false;
			} else if (CarUserControl.distance1 < 50 && tag == false) {
				tag = true;
			}
			GameObject.Find ("Canvas/Text").GetComponent<Text> ().text = "Money: " + money;
		}
			
	}
}

