using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : IState
{
    public void Action(Animator animator, Rigidbody2D rigidbody)
    {
        animator.Play("Die");

        rigidbody.gravityScale = 0.0f;
    }
}