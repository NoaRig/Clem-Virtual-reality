using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class spawnagent : MonoBehaviour
{

public GameObject[] Players;
void OnTriggerEnter(Collider otherObj)
   {
	if(otherObj.gameObject.tag == "user")
	{
		Instantiate (Players[Random.Range(0,Players.Length)]);
	}			
   }
}
