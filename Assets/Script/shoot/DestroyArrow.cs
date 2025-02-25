using UnityEngine;

public class DestroyArrow : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("metal")) // Ensure the bottle has the tag "Bottle"
        {
            Destroy(gameObject); // Destroy only the arrow
        }
        else if (collision.gameObject.CompareTag("plastic")) // Ensure the bottle has the tag "Bottle"
        {
            Destroy(gameObject); // Destroy only the arrow
        }
        else if (collision.gameObject.CompareTag("paper")) // Ensure the bottle has the tag "Bottle"
        {
            Destroy(gameObject); // Destroy only the arrow
        }
        else if (collision.gameObject.CompareTag("glass")) // Ensure the bottle has the tag "Bottle"
        {
            Destroy(gameObject); // Destroy only the arrow
        }
    }
}
