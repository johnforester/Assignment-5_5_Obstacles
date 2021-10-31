using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttacher : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (tag == "Goal")
            {
                Debug.Log("GOOOAL");
            }
            else
            {
                Debug.Log("beep");
                other.transform.parent = transform;
                //gameObject.GetComponent<MeshRenderer>().enabled = true;
            }
        }
            
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
            other.transform.parent = null;
    }

}
