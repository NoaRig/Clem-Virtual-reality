using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpacityChanger : MonoBehaviour
{
     public bool active = true;
     public GameObject flashlight;
     public GameObject flashlightTwo;

    // Update Function
    public void Bitch()
     {
         // If The Flashlight Button Is Pressed
         if (Input.GetKeyDown(KeyCode.E))
         {
             // Toggles The Active Bool
             active = !active;
             // If It Is Active
             if (active)
             {
                 flashlight.GetComponent<Light>().enabled = true;
                 flashlightTwo.GetComponent<Light>().enabled = true;
            }
             // If Not
             else
             {
                 flashlight.GetComponent<Light>().enabled = false;
                 flashlightTwo.GetComponent<Light>().enabled = false;
            }
         }
     }
    
    }
