using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelAnimation : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        animator.SetBool("IsPlay", true);
    }
}
