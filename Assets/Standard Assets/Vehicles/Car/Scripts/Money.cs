using System;
using UnityEngine;
using UnityEngine.UI;

namespace UnityStandardAssets.Vehicles.Car
{
	public class Money : MonoBehaviour
	{
		public static int money = 0;
		public static bool isOccupied;
		bool tag=true;
		void Update(){
			if (CarUserControl.distance0 < 50 && isOccupied == true) {
				money += 50;
				isOccupied = false;
				tag = false;
			} else if (CarUserControl.distance1 < 50 && tag == false) {
				tag = true;
			}
			GameObject.Find ("Canvas/Text").GetComponent<Text> ().text = "Money: " + money + "\nis Occupied: " + isOccupied;
		}
			
	}
}

