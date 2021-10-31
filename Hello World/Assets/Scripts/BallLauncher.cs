using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour
{
    [SerializeField] float rate = 1f;
   
    [SerializeField] GameObject ballPrefab;

    private float nextFireTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextFireTime)
        {
            nextFireTime += rate;
            FireProjectile();
        }
    }

    private void FireProjectile()
    {
        Instantiate(ballPrefab, transform);
    }
}
