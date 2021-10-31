using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathedPlatform : MonoBehaviour
{
    [SerializeField] float speed = 2.0f;
    [SerializeField] GameObject endPoint;
    [SerializeField] bool startOnPlayerTouch = true;

    private Vector3 startPoint;
    private Vector3 targetPoint;
    private bool movementStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        startPoint = transform.position;
        targetPoint = endPoint.transform.position;
        movementStarted = !startOnPlayerTouch;
    }

    void FixedUpdate()
    {
        if (!movementStarted && startOnPlayerTouch)
        {
            return;
        }

        var movementThisFrame = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targetPoint, movementThisFrame);

        if (Equals(targetPoint, transform.position))
        {
            if (Equals(targetPoint, endPoint.transform.position))
            {
                targetPoint = startPoint;
            }
            else
            {
                targetPoint = endPoint.transform.position;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (startOnPlayerTouch && other.CompareTag("Player"))
        {
            movementStarted = true;
        }

    }
}
