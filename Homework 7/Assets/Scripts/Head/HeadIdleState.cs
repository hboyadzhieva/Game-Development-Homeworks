using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadIdleState : StateMachineBehaviour
{
    private Animator animator;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        this.animator = animator;
        PlayerShootController.onShootWeapon += setShootTrigger;
        ZombieShootController.onZombieHitsPlayer += setHurtTrigger;
    }

    private void setShootTrigger() {
        animator.SetTrigger("isShooting");
    }

    private void setHurtTrigger() {
        animator.SetTrigger("isHurt");
    }
}
