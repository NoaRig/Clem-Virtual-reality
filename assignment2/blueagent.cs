using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class blueagent : MonoBehaviour
{

    public float wanderRadius;

    private Transform target;
    private NavMeshAgent nav;

    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
    Vector3 newPos = GetRandomPoint(transform.position, wanderRadius, -1);
    if(nav.remainingDistance <= nav.stoppingDistance + 0.7f){
        nav.SetDestination(newPos);
    }
    }

    public static Vector3 GetRandomPoint(Vector3 center, float maxDistance, int layermask) 
   { 
    Vector3 randomPos = Random.insideUnitSphere * maxDistance + center;

    NavMeshHit hit;
   
    NavMesh.SamplePosition(randomPos, out hit, maxDistance, NavMesh.AllAreas);

    return hit.position;
   }
}
