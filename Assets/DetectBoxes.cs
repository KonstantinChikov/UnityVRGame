using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectBoxes : MonoBehaviour
{
    private int cubesInside = 0;

    void Start()
    {
        if (GameObject.FindWithTag("cubeToDisappear") == null)
        {
            Debug.LogError("No GameObject with the tag 'cubeToDisappear' found in the scene!");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Box1") || other.CompareTag("Box2") || other.CompareTag("Box3") || other.CompareTag("Box4"))
        {
            cubesInside++;
            CheckCubes();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Box1") || other.CompareTag("Box2") || other.CompareTag("Box3") || other.CompareTag("Box4"))
        {
            cubesInside--;
        }
    }

    void CheckCubes()
    {
        if (cubesInside == 4)
        {
            GameObject cubeToDisappear = GameObject.FindWithTag("cubeToDisappear");
            if (cubeToDisappear != null)
            {
                cubeToDisappear.SetActive(false); // Make the cube disappear
            }
        }
    }
}
