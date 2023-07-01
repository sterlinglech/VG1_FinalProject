using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Grass : MonoBehaviour
{
    private void OnCollisionEnter2D(UnityEngine.Collision2D other)
    {
        if (other.gameObject.name == "Person"){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
