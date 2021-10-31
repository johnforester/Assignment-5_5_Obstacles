using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBoundary : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        // Collect pick ups
        if (other.CompareTag("Projectile"))
        {
            Destroy(other.gameObject);
        }
    }
}
