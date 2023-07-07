using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace FinalProject
{
    public class Grass : MonoBehaviour
    {
        private void OnCollisionEnter2D(UnityEngine.Collision2D other)
        {
            foreach (ContactPoint2D c in other.contacts)
            {
                if (c.collider.gameObject.name == "Person")
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                    break;
                }
            }
        }
    }
}

