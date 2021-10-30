using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    public int counter;

    public GameObject bonusPrefab;

    // Start is called before the first frame update
    void Start()
    {
        counter = GameObject.FindGameObjectsWithTag("Pick Up").Length;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pickup()
    {
        counter--;

        if (counter == 0)
        {
            SpawnBonus();
        }
    }

    public void SpawnBonus()
    {
        GameObject.Instantiate(bonusPrefab, transform);   
    }
}
