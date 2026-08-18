using UnityEngine;

public class Driver : MonoBehaviour
{
    float moveSpeed = 0.005f;
    float steerSpeed = 0.05f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(0, 0, steerSpeed);
        transform.Translate(0, moveSpeed, 0);
    }
}