using UnityEngine;
using static UnityEngine.Mathf;

public class AICrouchKickState : StateMachineBehaviour
{
    private Animator animator;
    private MovementController movementController;
    private GameObject hitbox;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        this.animator = animator;
        float kickDirection = Sign(animator.transform.localScale.x);
        hitbox = animator.transform.GetChild(2).gameObject;
        hitbox.SetActive(true);

        movementController = animator.GetComponent<MovementController>();
        movementController.SetHorizontalMoveDirection(kickDirection);
    }


    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        hitbox.SetActive(false);
    }
}
