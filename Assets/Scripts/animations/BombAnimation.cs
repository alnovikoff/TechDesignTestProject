using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombAnimation : MonoBehaviour
{
    private Animator _animator;
    private AudioSource _aus;

    private ParticleSystem particle1;
    private ParticleSystem particle2;

    [SerializeField] private List<AudioClip> clips;

    void Start()
    {
        _animator = GetComponent<Animator>();
        _aus = GetComponent<AudioSource>();
        particle1 = this.gameObject.transform.GetChild(0).GetComponent<ParticleSystem>();
        particle2 = this.gameObject.transform.GetChild(1).GetComponent<ParticleSystem>();
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


    void FireSoundPlay()
    {
        _aus.clip = clips[0];
        _aus.PlayOneShot(clips[0]);
        //_aus.Play();
        particle1.Play();
        particle2.Play();
    }

    void ExplosionPlay()
    {
        _aus.clip = clips[1];
        _aus.PlayOneShot(clips[1]);
        //_aus.Play();
    }
    void FallSoundPlay()
    {
        _aus.clip = clips[2];
        _aus.PlayOneShot(clips[2]);
        //_aus.Play();
    }
}
