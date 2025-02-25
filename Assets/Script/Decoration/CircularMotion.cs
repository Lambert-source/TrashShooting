using UnityEngine;

public class CircularMotion : MonoBehaviour
{
    public Transform centerPoint;  // The object to orbit around
    public float radius = 5f;      // Orbit radius
    public float speed = 2f;       // Orbit speed
    private float angle = 0f;

    void Update()
    {
        angle += speed * Time.deltaTime;

        float x = centerPoint.position.x + Mathf.Cos(angle) * radius;
        float z = centerPoint.position.z + Mathf.Sin(angle) * radius;

        transform.position = new Vector3(x, transform.position.y, z);
    }
}
