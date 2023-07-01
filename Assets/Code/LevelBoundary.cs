using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelBoundary : MonoBehaviour
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
}
