using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour {
    private AudioSource audio;
    public AudioClip audioClip;

    private bool audioHasBeenPlayed = false;

    void Start ()
    {
        audio = GetComponent<AudioSource>();
	}

    public void playAudio()
    {
        if (audioHasBeenPlayed == false)
        {
            audio.clip = audioClip;
            audio.Play();
            audioHasBeenPlayed = true;
        }
    }
}
