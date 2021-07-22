using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip _soundSelect;
    public AudioClip _soundDelete;
    public AudioClip _soundExplosion;
    AudioSource _audioSource;
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlaySelectSound(){
        _audioSource.PlayOneShot(_soundSelect);
    }
    public void PlayDeleteSound(){
        _audioSource.PlayOneShot(_soundDelete);
    }
    public void PlayExplosion(){
        _audioSource.PlayOneShot(_soundExplosion);
    }
}
