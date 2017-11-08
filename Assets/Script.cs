using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour {

    public AudioClip mai;
    public AudioClip speriat;
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void OnButtonMaiPressed()
    {
        audioSource.clip = mai;
        audioSource.Play();
    }

    public void OnButtonTeaiSperiatPressed()
    {
        audioSource.clip = speriat;
        audioSource.Play();
    }
}
