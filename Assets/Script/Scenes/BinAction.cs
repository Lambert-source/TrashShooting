using UnityEngine;

public class MovingDustbin : MonoBehaviour
{
    public float speed = 1f; // Speed of the movement
    public float moveDistance = 5f; // How far the bin moves from its start position
    public bool moveBackFirst = true; // Determines initial direction

    private Vector3 startPos;
    private int direction; // 1 = forward, -1 = back

    void Start()
    {
        startPos = transform.position; // Store the starting position
        direction = moveBackFirst ? -1 : 1; // Set initial direction
    }

    void Update()
    {
        // Move the bin forward and backward along the Z axis
        transform.position += new Vector3(0, 0, speed * direction * Time.deltaTime);

        // Check if the bin has moved beyond the allowed distance
        if (Mathf.Abs(transform.position.z - startPos.z) >= moveDistance)
        {
            direction *= -1; // Reverse direction
        }
    }
}