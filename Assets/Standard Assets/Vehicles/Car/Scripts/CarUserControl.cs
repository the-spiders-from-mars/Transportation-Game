using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use
		public static double distance0=0;
		public static double distance1 = 0;

        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }


        private void FixedUpdate()
        {
			distance0 = System.Math.Pow (System.Math.Abs(transform.localPosition.x-202),2)+System.Math.Pow (System.Math.Abs(transform.localPosition.z-10),2);
			distance0 = System.Math.Pow (distance0, 0.5);
			distance1 = System.Math.Pow (System.Math.Abs(transform.localPosition.x-11),2)+System.Math.Pow (System.Math.Abs(transform.localPosition.z-50),2);
			distance1 = System.Math.Pow (distance1, 0.5);
			// pass the input to the car!
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            float v = CrossPlatformInputManager.GetAxis("Vertical");
#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            m_Car.Move(h, v, v, handbrake);
#else
            m_Car.Move(h, v, v, 0f);
#endif
        }
    }
}
