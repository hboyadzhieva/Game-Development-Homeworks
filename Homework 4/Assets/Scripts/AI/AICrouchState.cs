﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICrouchState : StateMachineBehaviour
{
  
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        float rand = Random.value;
        if (rand <= 0.4f) {
            animator.SetTrigger("ShouldCrouchKick");
        }
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

}
