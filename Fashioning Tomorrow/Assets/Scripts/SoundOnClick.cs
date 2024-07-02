using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnClick : MonoBehaviour
{
    public AudioClip soundToPlay;
    private AudioSource audioSource;

    private void Start()
    {
        // Add an AudioSource component to the GameObject this script is attached to
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = soundToPlay;
    }

    private void OnMouseDown()
    {
        if (soundToPlay != null)
        {
            // Check if the AudioSource is not playing to prevent overlapping sounds
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
    }

}
