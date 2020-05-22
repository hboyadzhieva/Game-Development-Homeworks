using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class WeaponIdleState : StateMachineBehaviour
{

    private Animator animator;
 
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        this.animator = animator;
        PlayerShootController.onShootWeapon += setShootTrigger;
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        if (Input.GetMouseButtonDown(0)) {
            PlayerShootController.shoot();
        }

    }

    private void setShootTrigger() {
        animator.SetTrigger("weaponShot");
    }
}
