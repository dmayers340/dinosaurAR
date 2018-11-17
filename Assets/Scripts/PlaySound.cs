using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour {
    private AudioSource audio;
    
    void Start ()
    {
        audio = GetComponent<AudioSource>();
	}

    public void playAudio()
    {
        audio.Play();
    }
}
