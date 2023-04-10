using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }

    [Header("Audio clips.")]
    public AudioClip _BlasterSFX;
    public AudioClip _ExplosionSFX;

    [Space(20)]
    [SerializeField] private AudioSource _source;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
            return;
        }

        Destroy(this.gameObject);
    }

    public void PlaySound(AudioClip _clip, float _volumeScale)
    {
        _source.PlayOneShot(_clip, _volumeScale);
    }

}
