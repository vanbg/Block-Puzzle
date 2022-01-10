using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageShould : MonoBehaviour
{
    public static ManageShould instance;
    public GameObject prefab;

    public AudioClip click;
    private AudioSource clickSource;
    public AudioClip Point;
    private AudioSource PointSource;
    public AudioClip Congratulation;
    private AudioSource CongratulationSource;

    private void Awake()
    {
        instance = this;
    }

    public void PlaySound(AudioClip clip,float volume,bool isloopback)
    {
            //if(clip == this.click)
            //{
            //    Play(clip, ref clickSource, volume, isloopback);
            //}
    }

    public void PlaySound(AudioClip clip, float volume)
    {
        if(clip == this.click)
        {
            Play(clip, ref clickSource, volume);
            return;
        }
        if (clip == this.Point)
        {
            Play(clip, ref PointSource, volume);
            return;
        }
        if (clip == this.Congratulation)
        {
            Play(clip, ref CongratulationSource, volume);
            return;
        }
    }

    public void StopSound(AudioClip clip)
    {
        if(this == this.click)
        {
            clickSource?.Stop();
            return;
        }
        if (this == this.Point)
        {
            PointSource?.Stop();
            return;
        }
        if (this == this.Congratulation)
        {
            CongratulationSource?.Stop();
            return;
        }
    }

    private void Play(AudioClip clip, ref AudioSource audioSource, float volume, bool isloopback = false)
    {
        if(audioSource != null && audioSource.isPlaying)// hieu ung am thanh do dang duoc choi thi thoat
        {
            return;
        }

        audioSource = Instantiate(instance.prefab).GetComponent<AudioSource>();

        audioSource.volume = volume;
        audioSource.loop = isloopback;
        audioSource.clip = clip;
        audioSource.Play();

        Destroy(audioSource.gameObject, audioSource.clip.length);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
