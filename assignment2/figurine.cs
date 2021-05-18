using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class figurine : MonoBehaviour
{
   public GameObject[] Players;
    // Start is called before the first frame update
    void Start()
    {
        Players = GameObject.FindGameObjectsWithTag("yellow");
        Players = GameObject.FindGameObjectsWithTag("blue");
    }
}
