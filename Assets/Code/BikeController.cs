using UnityEngine;

public class BikeController : MonoBehaviour
{

    public float bikeVelocity = 0f;
    public float bikeAcceleration = 10f;

    public float rotationDelta = 20f;
    public float rotation = 0f;

    private Rigidbody2D rb;
    private Vector2 velocity;

    void Start() 
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        // Positive acceleration using the Space Key
        if (Input.GetKey(KeyCode.Space))
        {
            bikeVelocity += bikeAcceleration * Time.deltaTime;
        }

        // Negative acceleration using the 'R' Key
        if (Input.GetKey(KeyCode.R))
        {
            bikeVelocity -= bikeAcceleration * Time.deltaTime;
        }

        // Handle rotation counter-clockwise using the Left Arrow Key
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rotation += rotationDelta * Time.deltaTime;
        }

        // Handle rotation clockwise using the Right Arrow Key
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rotation -= rotationDelta * Time.deltaTime;
        }


        // Update the bike's position=
        //velocity = new Vector2(bikeVelocity, 0);
        //rb.velocity = velocity;

        // Update the bike's rotation
        rb.transform.localRotation = Quaternion.Euler(0, 0, rotation);
    }
}
