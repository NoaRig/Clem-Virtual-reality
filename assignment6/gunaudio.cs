using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunaudio : MonoBehaviour
{
    public AudioClip source;
    public AudioClip source1;
    public AudioClip source2;
    public AudioClip source3;
    public AudioClip source4;
    private int randomsound;

    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = source;
    }

    void OnCollisionEnter(Collision bigbullet)
    {
        if (bigbullet.collider.tag == "bullet")
        {
            randomsound = Random.Range(1, 6);
            if (randomsound == 1)
            {
                GetComponent<AudioSource>().clip = source;
            }
            else if (randomsound == 2)
            {
                GetComponent<AudioSource>().clip = source1;
            }
            else if (randomsound == 3)
            {
                GetComponent<AudioSource>().clip = source2;
            }
            else if (randomsound == 4)
            {
                GetComponent<AudioSource>().clip = source3;
            }
            else if (randomsound == 5)
            {
                GetComponent<AudioSource>().clip = source4;
            }
            GetComponent<AudioSource>().Play();
        }
    }

}
