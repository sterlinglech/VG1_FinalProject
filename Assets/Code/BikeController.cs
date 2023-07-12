using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

namespace FinalProject
{
    public class BikeController : MonoBehaviour
    {
        KeyCode RHS = KeyCode.RightArrow;
        KeyCode LHS = KeyCode.LeftArrow;
        KeyCode CW = KeyCode.DownArrow;
        KeyCode CCW = KeyCode.UpArrow;
        KeyCode BOOST = KeyCode.Space;
        KeyCode SUPER_BOOST = KeyCode.Q;

        Rigidbody2D _rb;

        // Configuration
        public float boostStrength;
        public float rotationSpeed;
        public float moveSpeed;
        public Image imageBoosts;
        public int superBoostDuration;
        public float superBoostGravityScale;
        public float normalGravityScale;

        // State Tracking
        public int maxBoosts;
        public int boosts; // number of boosts

        // Outlets
        public TMP_Text superBoost;

        bool isGrounded;

        private void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
            boosts = maxBoosts;
            _rb.gravityScale = normalGravityScale;
        }

        public void CollisionDetected(RearTireController rearTire)
        {
            isGrounded = true;
        }

        public void CollisionExited(RearTireController rearTire)
        {
            isGrounded = false;
        }

        void Update() // Update is called once per frame
        {
            // Rotate Counter-clockwise
            if (Input.GetKey(CCW))
            {
                _rb.AddTorque(rotationSpeed * Time.deltaTime * 10f);
            }

            // Rotate Clockwise
            if (Input.GetKey(CW))
            {
                _rb.AddTorque(-rotationSpeed * Time.deltaTime * 10f);
            }

            if (Input.GetKeyDown(BOOST))
            {
                if(boosts >= 1)
                {
                    // TODO Boost animation
                    _rb.AddRelativeForce(Vector2.right * boostStrength * 10f);
                    boosts--;
                    imageBoosts.fillAmount = boosts / (float)maxBoosts;
                }
            }

            if (Input.GetKeyDown(SUPER_BOOST))
            {
                if (boosts == maxBoosts)
                {
                    // TODO Boost animation
                    StartCoroutine(Routine_SuperBoost());
                    boosts = 0;
                    imageBoosts.fillAmount = boosts / (float)maxBoosts;
                }
            }

            if (isGrounded) // cannot move if front is down
            {
                // Go RHS
                if (Input.GetKey(RHS))
                {
                    _rb.AddRelativeForce(Vector2.right * moveSpeed * Time.deltaTime * 10f);
                }
                // Go LHS
                if (Input.GetKey(LHS))
                {
                    _rb.AddRelativeForce(Vector2.left * moveSpeed * Time.deltaTime * 10f);
                }
            }
            UpdateDisplay_SuperBoost();
        }
        void UpdateDisplay_SuperBoost()
        {
            if (boosts == maxBoosts)
            {
                superBoost.text = "Press Q to SUPER BOOST!";
            }
            else
            {
                superBoost.text = "";
            }
                
        }
        public IEnumerator Routine_SuperBoost()
        {
            _rb.gravityScale = superBoostGravityScale;
            yield return new WaitForSeconds(superBoostDuration); //You may change this number of seconds
            _rb.gravityScale = normalGravityScale;
        }
    }
}

