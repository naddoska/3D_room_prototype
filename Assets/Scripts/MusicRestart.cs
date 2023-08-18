using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicRestart : MonoBehaviour
{
    private Transform listener;
    private AudioSource audioSource;
    private float audioSource_fastMinDistance;
    private bool wasAbleToHear;

    // Start is called before the first frame update
    void Start()
    {
        //get first AudioSource of this GameObject
        audioSource = transform.GetComponent<AudioSource>();
        audioSource_fastMinDistance = audioSource.maxDistance * audioSource.maxDistance;
    }

    private float FastLength(Vector3 v) => v.x * v.x + v.y * v.y + v.z * v.z;
    //it is fast, cause we don't calculate the square root, to get the actual length of given vector

    // Update is called once per frame
    void Update()
    {
        //make sure to get the listener
        if (listener == null)
        {
            listener = FindObjectOfType<AudioListener>().transform;
            // Debug.LogWarning("Mon: listener was a null.");
            return;
        }
        //calculate distance fast Distance
        float current_fast_distance = FastLength(listener.position - transform.position);
        if (wasAbleToHear)
        {
            if (current_fast_distance > audioSource_fastMinDistance)
            {
                //exits the sound min distance
               // Debug.Log("exit");
                audioSource.Stop(); //this is kinda optional
                wasAbleToHear = false;
            }
        }
        else
        {
            if (current_fast_distance <= audioSource_fastMinDistance)
            {
                //enters the sound min distance
                // Debug.Log("enter");
                audioSource.Play();
                wasAbleToHear = true;
            }
        }
    }
}