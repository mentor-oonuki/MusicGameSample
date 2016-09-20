using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class MusicManager : SingletonMonoBehaviour<MusicManager>
{
    [SerializeField] private AudioClip audioClip;

    private AudioSource audioSource;

    void Start ()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClip;
    }
	
	void Update ()
    {

	}

    public void Play()
    {
        audioSource.Play();
    }

    public void Stop()
    {
        audioSource.Stop();
    }

}
