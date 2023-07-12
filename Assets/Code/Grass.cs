using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace FinalProject
{
    public class Grass : MonoBehaviour
    {
        // Outlets
        public TMP_Text lost_message_land_on_head;

        private void OnCollisionEnter2D(UnityEngine.Collision2D other)
        {
            foreach (ContactPoint2D c in other.contacts)
            {
                GameObject o = c.collider.gameObject;
                if (o.name == "Person")
                {
                    // TODO check person's shield charges; update it or delete person
                    Person p = o.GetComponent<Person>();
                    if (p.shieldCharges <= 0)
                    {
                        StartCoroutine(Routine_Lose_land_on_head());
                        break;
                    }
                    else
                    {
                        p.shieldCharges -= 1;
                        // TODO possible 'hurt' animation
                        break;

                    }
                    
                }
            }
        }
        public IEnumerator Routine_Lose_land_on_head()
        {
            lost_message_land_on_head.text = "You landed on your HEAD!";
            yield return new WaitForSeconds(2.4f); //You may change this number of seconds
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}

