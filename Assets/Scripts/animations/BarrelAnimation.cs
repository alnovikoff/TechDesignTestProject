using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelAnimation : MonoBehaviour
{
    private Animator _animator;
    private AudioSource _aus;

    private ParticleSystem particle;

    [SerializeField] private List<AudioClip> clips;

    void Start()
    {
        _animator = GetComponent<Animator>();
        _aus = GetComponent<AudioSource>();
        particle = this.gameObject.transform.GetChild(1).GetComponent<ParticleSystem>();
    }

    void OnMouseDown()
    {
        _animator.SetBool("IsPlay", true);
        Invoke("StopPlay", 1f);
    }

    private void StopPlay()
    {
        _animator.SetBool("IsPlay", false);
    }


    void MetalSoundPlay()
    {
        _aus.clip = clips[0];
        //_aus.Play();
        _aus.PlayOneShot(clips[0]);
    }

    void PourSoundPlay()
    {
        _aus.clip = clips[1];
        //_aus.Play();
        _aus.PlayOneShot(clips[1]);
        particle.Play();
    }
}
