using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject teleportSpot = GameObject.FindWithTag("teleportingSpot");

            if (teleportSpot != null)
            {
                other.transform.position = teleportSpot.transform.position;
                Debug.Log("Player teleported to: " + teleportSpot.transform.position);
            }
            else
            {
                Debug.LogError("No GameObject with the tag 'teleportingSpot' found in the scene!");
            }
        }
    }
}
