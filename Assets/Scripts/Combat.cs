using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    public Animator animator;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }

    }
    void Attack()
    {
        animator.SetTrigger("Attack");
    }

}
