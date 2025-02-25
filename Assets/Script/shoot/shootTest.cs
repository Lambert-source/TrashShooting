using UnityEngine;

public class shootTest : MonoBehaviour
{
 

    private Rigidbody rb;
    public float speed = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // Ensure kinematic is OFF so we can set velocity
        rb.isKinematic = false;
    }

    void Update()
    {
        rb.linearVelocity = transform.right * speed; // Moves in the X direction
    }

}


// Start is called once before the first execution of Update after the MonoBehaviour is created
// public float speed;
//private void Update()
// {
//    transform.Translate(Vector3.right * speed * Time.deltaTime); // Moves in the +X direction
// }


