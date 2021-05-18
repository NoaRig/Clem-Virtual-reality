using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class yellowagent : MonoBehaviour
{
    NavMeshAgent nav;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("user").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
       nav.SetDestination(target.position);
    }
}
