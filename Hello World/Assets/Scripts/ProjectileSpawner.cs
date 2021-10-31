using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    [SerializeField] float rate = 1f;
    [SerializeField] float speed = 1f;
    [SerializeField] Vector3 direction;

    [SerializeField] GameObject projectilePrefab;

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

        if (speed > 0f)
        {
            GameObject projectile = Instantiate(projectilePrefab, transform);
            projectile.GetComponent<Rigidbody>().velocity = speed * direction;
        }
        else
        {
            Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        }
    }
}
