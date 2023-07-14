using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace FinalProject
{
    public class newBikeController : MonoBehaviour
    {
        // Rigid body instance of the bike itself
        Rigidbody2D _rb;

        // Outlets
        // Rigidbody2D _rb;
        // WheelJoint2D _wj;
        [SerializeField] private WheelJoint2D wheelLeft;
        [SerializeField] private WheelJoint2D wheelRight;

        // Inputs
        public float speed;
        public float torque;
        public float bikeRotationSpeed;

        private JointMotor2D _increasingMotorSpeed;
        private JointMotor2D _startingMotorSpeed;
        private JointMotor2D _motorRight;


        // Start is called before the first frame update
        void Start()
        {
            // Instantiate the instance of the rigidbody this script is attached to (the bike)
            _rb = GetComponent<Rigidbody2D>();

            //_rb = GetComponent<Rigidbody2D>();
            //_wj = GetComponent<WheelJoint2D>();
            _increasingMotorSpeed.motorSpeed = .1f;
            _increasingMotorSpeed.maxMotorTorque = 100f;
            _startingMotorSpeed.motorSpeed = 0f;
            _startingMotorSpeed.maxMotorTorque = 100f;
            wheelLeft.motor = _startingMotorSpeed;
        }

        // Update is called once per frame
        void Update()
        {
            //_motorLeft.motorSpeed = speed;
            //_motorRight.motorSpeed = speed;
            //_motorLeft.maxMotorTorque = torque;
            //_motorRight.maxMotorTorque = torque;

            // Rotate Left
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                _rb.AddTorque(bikeRotationSpeed * Time.deltaTime * 10f);
            }

            // Rotate Right
            if (Input.GetKey(KeyCode.RightArrow))
            {
                _rb.AddTorque(-bikeRotationSpeed * Time.deltaTime * 10f);
            }


            // Add increasing motor speed while holding down the Space Key
            // Speed capped at 2800f because the wheel joint flips out at higher motor speeds.
            if (Input.GetKey(KeyCode.Space) && _increasingMotorSpeed.motorSpeed < 2800f)
            {
                _increasingMotorSpeed.motorSpeed += 2f;

                // Show us the value of motorspeed each frame so that we can test its limits
                Debug.Log("motorSpeed = " +_increasingMotorSpeed.motorSpeed.ToString());
            }

            // Decrease the motor speed while holding down the R Key
            if (Input.GetKey(KeyCode.R))
            {
                _increasingMotorSpeed.motorSpeed -= 1f;
            }
                                     
            // Decrease the motor speed if the controls are idle
            if ((Input.GetKeyDown(KeyCode.Space) == false) && (wheelLeft.motor.motorSpeed > 0f))
            {
                _increasingMotorSpeed.motorSpeed -= .4f;
            }

            wheelLeft.motor = _increasingMotorSpeed;
            //wheelRight.motor = _increasingMotorSpeed;


            //wheelLeft.motor = _motorLeft;
            //wheelRight.motor = _motorRight;
            
        }
    }
}
