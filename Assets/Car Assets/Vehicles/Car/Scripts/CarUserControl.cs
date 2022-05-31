using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use
        float max_speed_limit = 0.5f;

        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }


        private void FixedUpdate()
        {
            // pass the input to the car!
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            float v = CrossPlatformInputManager.GetAxis("Vertical");
#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");

            
            m_Car.Move(h, v, v, handbrake, max_speed_limit);
#else
            m_Car.Move(h, v, v, 0f);
#endif
        }



        private void OnTriggerStay(Collider touch_acc)
        {
            float thrustTorque;
            if (touch_acc.gameObject.name == "acc_cube")
            {
                Debug.Log("acc");
                float h = CrossPlatformInputManager.GetAxis("Horizontal");
                float v = CrossPlatformInputManager.GetAxis("Vertical");
                float handbrake = CrossPlatformInputManager.GetAxis("Jump");
                max_speed_limit = 1.0f;
                m_Car.Move(h, v, v, handbrake, max_speed_limit);
                /**thrustTorque = 10 * (m_CurrentTorque / 4f);
                
                for (int i = 0; i < 4; i++)
                {

                    m_WheelColliders[i].attachedRigidbody.AddForce(-transform.up * 2f *
                                                         m_WheelColliders[i].attachedRigidbody.velocity.magnitude);
                    m_WheelColliders[i].motorTorque = thrustTorque;
                    //Debug.Log("thrustTorque" + thrustTorque);

                }**/
            }

        }
        private void OnTriggerExit(Collider touch_acc)
        {
            Debug.Log("exit");
            max_speed_limit = 0.5f;
        }



    }
}
