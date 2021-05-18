using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class rotateobject : MonoBehaviour
{

    public float speed = 10f;

    //public Vector3 RotateAmount;  

    void Update()
    {
        transform.Rotate(speed * Time.deltaTime, speed * Time.deltaTime, speed * Time.deltaTime);

    }
    // Update is called once per frame
    public void Rotate(float newspeed)
    {
        speed = newspeed;
    }
}
