using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bikeBreakerJointToBike : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "breakingPoint")
        {
            FixedJoint2D joint = this.gameObject.AddComponent<FixedJoint2D>();
            joint.connectedBody = collision.gameObject.GetComponent<Rigidbody2D>();
        }
    }
}
