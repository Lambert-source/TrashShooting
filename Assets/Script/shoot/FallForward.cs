using UnityEngine;

public class FallForward : MonoBehaviour
{
    private Rigidbody rb;
    private bool isShot = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true; // Keep bottle on shelf initially
    }

    public void FallSideways()
    {
        if (!isShot) // Prevent multiple activations
        {
            isShot = true;
            rb.isKinematic = false; // Enable physics
            rb.useGravity = true;    // Allow it to fall

            // RESET RIGIDBODY BEFORE APPLYING FORCE
            rb.linearVelocity = Vector3.zero; // Stop any unwanted movement
            rb.angularVelocity = Vector3.zero; // Reset rotation force

            // APPLY FORCE IN NEGATIVE X DIRECTION (-X, LEFT)
            rb.AddForce(new Vector3(40f, 10f, 0f), ForceMode.Impulse);
            //rb.AddForce(new Vector3(0f, -10f, 0f), ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Arrow")) // Ensure Arrow has the tag "Arrow"
        {
            // TEMPORARILY DISABLE RIGIDBODY FOR A MOMENT
            rb.isKinematic = true; // Freeze bottle
            Invoke(nameof(ReEnableRigidbody), 0.05f); // Re-enable after a short delay
        }
    }

    private void ReEnableRigidbody()
    {
        rb.isKinematic = false; // Unfreeze bottle
        FallSideways(); // Apply the movement force
    }
}




