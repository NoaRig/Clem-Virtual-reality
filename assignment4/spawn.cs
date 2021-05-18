using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class spawn : MonoBehaviour
{

	public GameObject[] Players;
	public void ballspawn()
	{
			Instantiate(Players[Random.Range(0, Players.Length)]);
	}
}
