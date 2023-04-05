using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    [Header("Audio clips.")]
    public AudioClip _BlasterSFX;
    public AudioClip _ExplosionSFX;

    [Space(20)]
    [SerializeField] private AudioSource _source;

    private void Awake()
    {
        Instance = this;
    }

    public void PlaySound(AudioClip _clip, float _volumeScale)
    {
        _source.PlayOneShot(_clip, _volumeScale);
    }
}
