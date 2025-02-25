using UnityEngine;

public class TrashBehaviour : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void ShootBottle(GameObject bottle)
    {
        Rigidbody rb = bottle.GetComponent<Rigidbody>();

        // Enable physics when shot
        rb.isKinematic = false;  // Allow it to move
        rb.useGravity = true;    // Make it fall
        rb.AddForce(Vector3.down * 5f, ForceMode.Impulse);
    }

}