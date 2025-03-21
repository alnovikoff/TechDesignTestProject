using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleAnimation : MonoBehaviour
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
        Invoke("StopPlay", 1f);
    }

    private void StopPlay()
    {
        _animator.SetBool("IsPlay", false);
    }

    public void PlayUp()
    {
        _aus.clip = clips[0];
        _aus.PlayOneShot(clips[0]);
        //_aus.Play();
    }

    public void PlayDown()
    {
        _aus.clip = clips[1];
        _aus.PlayOneShot(clips[1]);
        //_aus.Play();
    }
}
