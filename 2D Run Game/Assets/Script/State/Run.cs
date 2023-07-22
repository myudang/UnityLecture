using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : IState
{
    public void Action(Animator animator, Rigidbody2D rigidbody)
    {
        animator.SetBool("Jump", false);
    }
}
