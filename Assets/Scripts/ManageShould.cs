using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageShould : MonoBehaviour
{
    public static ManageShould instance;
    public GameObject prefab;

    public AudioClip soundtrack;
    private AudioSource soundtrackSource;
    public AudioClip click;
    private AudioSource clickSource;
    public AudioClip Point;
    private AudioSource PointSource;
    public AudioClip Congratulation;
    private AudioSource CongratulationSource;
    public AudioClip GameOver;
    private AudioSource GameOverSource;
    public AudioClip btn;
    private AudioSource btnSource;

    private void Awake()
    {
        instance = this;
    }

    public void PlaySound(AudioClip clip,float volume,bool isloopback)
    {
            if(clip == this.soundtrack)
            {
                Play(clip, ref soundtrackSource, volume, isloopback);
            }
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
        if (clip == this.GameOver)
        {
            Play(clip, ref GameOverSource, volume);
            return;
        }
        if (clip == this.btn)
        {
            Play(clip, ref btnSource, volume);
            return;
        }
    }

    public void StopSound(AudioClip clip)
    {
        if (this == this.soundtrack)
        {
            clickSource?.Stop();
            return;
        }
        if (this == this.click)
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
        if (this == this.GameOver)
        {
            CongratulationSource?.Stop();
            return;
        }
        if (this == this.btn)
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

}
