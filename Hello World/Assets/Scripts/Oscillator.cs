using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [Header("Movement parameters")]
    [SerializeField] Vector3 movementAxis;
    [SerializeField] float movementSpeed;
    [SerializeField] float movementDistance;

    [Header("Movement positions")]
    private Vector3 startingPosition;
    public Vector3 positiveEnd;
    public Vector3 negativeEnd;

    private Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        // Direction of movement
        direction = movementAxis.normalized;

        startingPosition = transform.position;
        positiveEnd = transform.position + (direction * movementDistance);
        negativeEnd = transform.position - (direction * movementDistance);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Vector3.Distance(transform.position, positiveEnd) < 0.01f ||
            Vector3.Distance(transform.position, negativeEnd) < 0.01f)
        {
            direction *= -1;
        }

        // Move platform
        transform.Translate(direction * movementSpeed * Time.deltaTime);
    }
}
