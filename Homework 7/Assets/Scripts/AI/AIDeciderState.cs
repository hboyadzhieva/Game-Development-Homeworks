using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIDeciderState : StateMachineBehaviour
{

    private Animator animator;
    [SerializeField]
    [Range(0f, 0.4f)]
    private float attackRate = 0.02f;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        this.animator = animator;
        float rand = Random.value;
        if (rand <= attackRate) {
            animator.SetTrigger("shouldFire");
        } else {
            animator.SetTrigger("shouldWait");
        }
    }
}
