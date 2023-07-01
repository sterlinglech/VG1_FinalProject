using UnityEngine;

public class BikeController : MonoBehaviour
{
    Rigidbody2D _rb;

    public float rotationSpeed;
    public float moveSpeed;

    bool isGrounded;

    void Start() 
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    public void CollisionDetected(RearTireController rearTire)
    {
        isGrounded = true;
    }

    public void CollisionExited(RearTireController rearTire)
    {
        isGrounded = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate Left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _rb.AddTorque(rotationSpeed * Time.deltaTime * 10f);
        }

        // Rotate Right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _rb.AddTorque(-rotationSpeed * Time.deltaTime * 10f);
        }

        if (isGrounded)
        {
            // Go Forward
            if (Input.GetKey(KeyCode.UpArrow))
            {
                _rb.AddRelativeForce(Vector2.right * moveSpeed * Time.deltaTime * 10f);
            }

<<<<<<< HEAD
        // Update the bike's position=
        //velocity = new Vector2(bikeVelocity, 0);
        //rb.velocity = velocity;

        // Update the bike's rotation
        rb.transform.localRotation = Quaternion.Euler(0, 0, rotation);
=======
            // Go Backward
            if (Input.GetKey(KeyCode.DownArrow))
            {
                _rb.AddRelativeForce(Vector2.left * moveSpeed * Time.deltaTime * 10f);
            }
        }
>>>>>>> bdb16aa1d7a556f08710e192b8f5e7a2be988a5f
    }
}
