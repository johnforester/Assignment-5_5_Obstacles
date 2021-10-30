using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Transform spawnPoint;
    public CharacterController player;
 
    public Bonus bonusSpawner;

    private void Start()
    {//A = (3, -3, 1) and B = (4, 9, 2), 
        Vector3 i = new Vector3(1, 0, 0);
        Vector3 j = new Vector3(0, 1, 0);

        Vector3 k = new Vector3(0, 0, 1);

        Debug.Log("i  . j " + Vector3.Dot(i, j));
        
        Debug.Log("j  . k " + Vector3.Dot(j, k));

        Debug.Log("k  . i " + Vector3.Dot(k, i));

        //Vector3 a = new Vector3(1, 4, 0);
        //Vector3 b = new Vector3(4, 2, 4);

        //Debug.Log("a projection b " + Vector3.Project(a, b));
        //Debug.Log("a rejection b " + (a - Vector3.Project(a, b)));



        //Debug.Log("i  * k " + Vector3.Cross(i, k));

    }

    // void Vector3 Project()

    private void OnTriggerEnter(Collider other) {
        // Collect pick ups
        if(other.CompareTag("Pick Up"))
        {
            Debug.Log("Pick up collected!");
            GameObject.Destroy(other.gameObject);

            if (bonusSpawner)
                bonusSpawner.gameObject.SendMessage("Pickup");
        }

        // Respawn after hitting fall zone
        if(other.CompareTag("Fall Zone"))
        {
            Debug.Log("Player has fallen out of bounds. Resetting position...");
            player.enabled = false;
            transform.SetPositionAndRotation(spawnPoint.position, spawnPoint.rotation);
            player.enabled = true;
        }
    }
}
