using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace FinalProject
{
    public class ResetSceneOnCollision : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.name == "Rear Tire" ||
                other.gameObject.name == "Front Tire" ||
                other.gameObject.name == "Body" ||
                other.gameObject.name == "Person")
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        private void OnCollisionEnter2D(Collision2D other)
        {
            // Reload scene iff: 'other' collides with player
            if (other.gameObject.GetComponent<BikeController>())
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}

