using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlendTree : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    void Start()
    {
        animator= GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Speed", Input.GetAxis("Vertical"));
    }
}
