using UnityEngine;
using UnityEngine.AI;

public class destroyagent : MonoBehaviour
{



 void OnTriggerEnter(Collider otherObj)
   {
		if(otherObj.gameObject.tag == "yellow"){
			Destroy(otherObj.gameObject);
		 }

		if(otherObj.gameObject.tag == "red"){
		Destroy(otherObj.gameObject);

		 }
		if(otherObj.gameObject.tag == "blue"){
		Destroy(otherObj.gameObject);

		 }
	}
}
