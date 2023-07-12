using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace FinalProject
{
    public class Target : MonoBehaviour
    {

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


