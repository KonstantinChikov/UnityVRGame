using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTarget : MonoBehaviour
{
    [SerializeField] private float speed = 2f;       
    [SerializeField] private float distance = 2f;  

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position; 
    }

    void Update()
    {
        float movement = Mathf.PingPong(Time.time * speed, distance) - (distance / 2);
        transform.position = startPosition + new Vector3(movement, 0, 0);
    }
}
