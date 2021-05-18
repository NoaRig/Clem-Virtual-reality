using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubemaker : MonoBehaviour
{
    //All of my shapedf and materials. this way i can assign the prefabs and colors to the correct location
    public Transform spawnpoint;

    public GameObject cube;
    
    public GameObject sphere;
    
    public GameObject capsule;

    public Material red;
    
    public Material blue;
    
    public Material green;

    public Material trred;

    public Material trblue;

    public Material trgreen;

    private GameObject instantiateObject;
    
    private Material instantiateMaterial;

    bool objectcolortrans;

    // section of code for the cube to be spawn in
    public void CubeBOY() {
        instantiateObject = cube; 
    }

    // section of code for the sphere to be spawn in
    public void sphereBOY() {
        instantiateObject = sphere; 
    }

    // section of code for the capsule to be spawn in
    public void capsuleBOY() {
        instantiateObject = capsule; 
    }

    // section of code for red to be chosen
    public void redBOY() {

        if (objectcolortrans == false)
        {
            instantiateMaterial = red;
        }
        if (objectcolortrans == true)
        {
            instantiateMaterial = trred;
        }
    }

    // section of code for blue to be chosen
    public void blueBOY()
    {

        if (objectcolortrans == false)
        {
            instantiateMaterial = blue;
        }
        if (objectcolortrans == true)
        {
            instantiateMaterial = trblue;
        }
    }

    // section of code for green to be chosen
    public void greenBOY() {

        if (objectcolortrans == false)
        {
            instantiateMaterial = green;
        }
        if (objectcolortrans == true)
        {
            instantiateMaterial = trgreen;
        }
    }

    // section of code to state if translucent should be on or off and helps with code above
    public void translucentBOY(bool i)
    {
        if(i == true)
        {
            objectcolortrans = true;
            TranslucentOn(instantiateMaterial);
        }

        if(i == false)
        {
            objectcolortrans = false;
            TranslucentOff(instantiateMaterial);
        }
    }

    // section of code that deals with translucent being set to on
    public void TranslucentOn(Material colo) 
    {
        if(colo == green) 
        {
            instantiateMaterial = trgreen;
        }

        else if (colo == blue)
        {
            instantiateMaterial = trblue;
        }

        else if (colo == red)
        {
            instantiateMaterial = trred;
        }
    }

    // section of code that deals with translucent being set to off
    public void TranslucentOff(Material colo)
    {
        if (colo == trgreen)
        {
            instantiateMaterial = green;
        }

        else if (colo == trblue)
        {
            instantiateMaterial = blue;
        }
        
        else if(colo == trred)
        {
            instantiateMaterial = red;
        }
    }

    // section of code that is used for the spawning of objects
    public void Spawn()
    {
        GameObject newspawn = Instantiate(instantiateObject, spawnpoint.position, Quaternion.identity);
        newspawn.GetComponentInChildren<Renderer>().sharedMaterial = instantiateMaterial;
    }
}
