using UnityEngine;
using UnityEngine.AI;

public class teleport : MonoBehaviour
{
    public GameObject theBall;
    public float radius;


void OnTriggerEnter(Collider otherObj)
   {
	if(otherObj.gameObject.tag == "red")
    {
        theBall.transform.position = new Vector3(Random.Range(-33,33),30,Random.Range(-33,33));   
    }
    
    if(otherObj.gameObject.tag == "blue")
    {
        theBall.transform.position = new Vector3(Random.Range(-33,33),30,Random.Range(-33,33));   
    }

    if(otherObj.gameObject.tag == "yellow")
    {
        theBall.transform.position = new Vector3(Random.Range(-33,33),30,Random.Range(-33,33));   
    }

   }

}
