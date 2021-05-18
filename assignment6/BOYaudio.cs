using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOYaudio : MonoBehaviour
{
    public AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "bullet")
        source.Play();
    }

}
