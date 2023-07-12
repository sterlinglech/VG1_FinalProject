using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

namespace FinalProject
{
    public class Target : MonoBehaviour
    {
        // Outlets
        public TMP_Text win;

        private void OnCollisionEnter2D(Collision2D other)
        {
            // Reload scene iff: 'other' collides with player
            if (other.gameObject.GetComponent<BikeController>())
            {
                StartCoroutine(Routine_Win());
            }
        }
        public IEnumerator Routine_Win()
        {
            win.text = "You WON!";
            yield return new WaitForSeconds(1.6f); //You may change this number of seconds
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}


