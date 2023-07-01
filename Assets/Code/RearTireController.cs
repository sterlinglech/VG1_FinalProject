using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RearTireController : MonoBehaviour
{
    private void OnCollisionExit2D(Collision2D collision)
    {
        transform.parent.GetComponent<BikeController>().CollisionExited(this);
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        transform.parent.GetComponent<BikeController>().CollisionDetected(this);
    }

}
