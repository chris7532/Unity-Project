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
        [SerializeField] ParticleSystem speed_line;
        Gradient grad = new Gradient();

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
            //float thrustTorque;
            if (touch_acc.gameObject.name == "acc_cube")
            {
                var col = speed_line.colorOverLifetime;
                var shape = speed_line.shape;
                var emission = speed_line.emission;

                //Color Over Lifetime
                grad.SetKeys(new GradientColorKey[] { new GradientColorKey(new Color(0.82f, 0.078f, 0.015f, 1), 0.0f), new GradientColorKey(Color.white, 1.0f) }, new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(0.0f, 1.0f) });

                col.color = grad;
                shape.radius = 11.5f;
                emission.rateOverTime = 500;

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
            var col = speed_line.colorOverLifetime;
            var shape = speed_line.shape;
            var emission = speed_line.emission;
            grad.SetKeys(new GradientColorKey[] { new GradientColorKey(new Color(0.17f, 0.58f, 1, 1), 0.0f), new GradientColorKey(Color.white, 1.0f) }, new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(0.0f, 1.0f) });
            col.color = grad;
            shape.radius = 13;
            emission.rateOverTime = 125;

            Debug.Log("exit");
            max_speed_limit = 0.5f;
        }



    }
}
