using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TargetHit : MonoBehaviour
{
    public ScoreManager scoreManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Weapon"))
        {
            scoreManager.AddScore(1);

        }
    }
}
