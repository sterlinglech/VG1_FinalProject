using UnityEngine;

namespace FinalProject
{
    public class BikeController : MonoBehaviour
    {
        Rigidbody2D _rb;

        public float rotationSpeed;
        public float moveSpeed;

        bool isGrounded;

        void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        public void CollisionDetected(RearTireController rearTire)
        {
            isGrounded = true;
        }

        public void CollisionExited(RearTireController rearTire)
        {
            isGrounded = false;
        }

        // Update is called once per frame
        void Update()
        {
            // Rotate Left
            if (Input.GetKey(KeyCode.UpArrow))
            {
                _rb.AddTorque(rotationSpeed * Time.deltaTime * 10f);
            }

            // Rotate Right
            if (Input.GetKey(KeyCode.DownArrow))
            {
                _rb.AddTorque(-rotationSpeed * Time.deltaTime * 10f);
            }

            if (isGrounded)
            {
                // Go Forward
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    _rb.AddRelativeForce(Vector2.right * moveSpeed * Time.deltaTime * 10f);
                }
                // Go Backward
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    _rb.AddRelativeForce(Vector2.left * moveSpeed * Time.deltaTime * 10f);
                }
            }
        }
    }
}

