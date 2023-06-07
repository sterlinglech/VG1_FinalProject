using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class FollowController : MonoBehaviour
{

    public GameObject character;
    public float speed = 10f;
    public float lerp = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get the position of the character object
        Vector3 characterPosition = character.transform.position;

        // Center the camera on the character object
        transform.localPosition = new Vector3(characterPosition.x, characterPosition.y, -10f);
    }
}
