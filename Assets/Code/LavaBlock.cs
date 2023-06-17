using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FinalProject {
    public class LavaBlock : MonoBehaviour
    {
        // Outlets
        Rigidbody2D _rb;

        // Configuration
        public float speed;

        // Methods
        private void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if(other.gameObject.GetComponent<BikeController>())
            {
                _rb.AddRelativeForce(Vector2.up * speed * Time.deltaTime);
            }
        }
    }
}