using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
     [SerializeField] private AudioSource audioSource;
    // public AudioClip buttonSoundClip;
     public AudioClip boxSoundClip;
     private void Start()
     {
         audioSource = GetComponent<AudioSource>();
     }
     
     public void BoxSound()
     {
         audioSource.clip = boxSoundClip;
         audioSource.Play();
     }
     
}
