﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static SoundManager Instance = null;

    public AudioClip rotateSound;
    public AudioClip rowDelete;
    public AudioClip shapeMove;
    public AudioClip shapeStop;
    public AudioClip gameOver;
    public AudioClip tetris;

    private AudioSource soundEffectAudio;

    // Use this for initialization
    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }

        AudioSource theSource = GetComponent<AudioSource>();

        soundEffectAudio = theSource;
    }

    public void PlayOneShot(AudioClip clip)
    {
        soundEffectAudio.PlayOneShot(clip);
    }
}
