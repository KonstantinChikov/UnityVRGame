using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ButtonPushOpenDoor : MonoBehaviour
{
    public GameObject victoryCanvas;
    void Start()
    {
        if (victoryCanvas != null)
        {
            victoryCanvas.SetActive(false);
        }
        else
        {
            Debug.LogError("Victory Canvas is not assigned in the Inspector!");
        }

        // Listen for button press
        GetComponent<XRSimpleInteractable>().selectEntered.AddListener(x => ToggleVictoryCanvas());
    }

    public void ToggleVictoryCanvas()
    {
        if (victoryCanvas != null)
        {
            bool isActive = victoryCanvas.activeSelf;
            victoryCanvas.SetActive(!isActive); // Toggle visibility
        }
    }
}

