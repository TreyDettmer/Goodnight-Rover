﻿using UnityEngine.Audio;
using UnityEngine;
using System;

[Serializable]
public class Sound
{
    public string name;
    public AudioClip clip;
    [Range(0f,1f)]
    public float volume;
    public bool isMusic;
    public bool loop;

    [HideInInspector]
    public AudioSource source;
    
}
