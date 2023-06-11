using UnityEngine;

public class BikeController : MonoBehaviour
{
    // Outlets
    Rigidbody2D _rb;

    public float moveDirection;
    public float moveSpeed;
    public float rotationSpeed;

    private bool isGrounded = false;

    void Start() 
    {
        _rb = GetComponent<Rigidbody2D>();

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.contactCount != 0)
        {
            isGrounded = true;
            //Debug.Log("Collision Entered" + other.contactCount);
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if(other.contactCount == 0)
        {
            isGrounded = false;
            //Debug.Log("Collision Exited" + other.contactCount);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate Left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _rb.AddTorque(rotationSpeed * Time.deltaTime);
        }

        // Rotate Right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _rb.AddTorque(-rotationSpeed * Time.deltaTime);
        }

        if(isGrounded)
        {
            // Go Forward
            if (Input.GetKey(KeyCode.UpArrow))
            {
                _rb.AddRelativeForce(Vector2.right * moveSpeed * Time.deltaTime);
            }

            // Go Backward
            if (Input.GetKey(KeyCode.DownArrow))
            {
                _rb.AddRelativeForce(Vector2.left * moveSpeed * Time.deltaTime);
            }
        }

    }
}
