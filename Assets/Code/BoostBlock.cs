using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FinalProject {
    public class RoostBlock : MonoBehaviour
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
                other.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * speed, ForceMode2D.Impulse);
            }
        }
    }
}