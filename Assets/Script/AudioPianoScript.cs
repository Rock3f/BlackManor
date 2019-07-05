using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPianoScript : MonoBehaviour
{
    public AudioClip pianoMusic;
    public AudioSource audiosource;

    public GameObject mycamera;
    public float distance;

    // Start is called before the first frame update
    void Start()
    {
        audiosource.clip = pianoMusic;
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(transform.position, mycamera.transform.position);
        // Debug.Log("Distance: "+distance);
        if(distance > 5.0)
        {
            wait();
            audiosource.Play();
        }
    }

    IEnumerator wait() {
        yield return new WaitForSeconds(90);
    }
}


