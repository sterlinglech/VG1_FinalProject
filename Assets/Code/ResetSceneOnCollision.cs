using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace FinalProject
{
    public class ResetSceneOnCollision : MonoBehaviour
    {
        // Outlets
        public TMP_Text lost_message_out_of_bounds;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.name == "Rear Tire" ||
                other.gameObject.name == "Front Tire" ||
                other.gameObject.name == "Body" ||
                other.gameObject.name == "Person")
            {
                StartCoroutine(Routine_Lose_out_of_bounds());
            }
        }

        public IEnumerator Routine_Lose_out_of_bounds()
        {
            lost_message_out_of_bounds.text = "You fell into the void below!";
            yield return new WaitForSeconds(2.4f); //You may change this number of seconds
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}

