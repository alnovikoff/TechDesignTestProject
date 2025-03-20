using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelAnimation : MonoBehaviour
{
    private Animator _animator;
    private AudioSource _aus;

    [SerializeField] private List<AudioClip> clips;

    void Start()
    {
        _animator = GetComponent<Animator>();
        _aus = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        _animator.SetBool("IsPlay", true);
    }

    void MetalSoundPlay()
    {
        _aus.clip = clips[0];
        _aus.Play();
    }

    void PourSoundPlay()
    {
        _aus.clip = clips[1];
        _aus.Play();
    }
}
