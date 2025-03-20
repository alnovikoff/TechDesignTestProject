using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleAnimation : MonoBehaviour
{
    private Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
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
}
