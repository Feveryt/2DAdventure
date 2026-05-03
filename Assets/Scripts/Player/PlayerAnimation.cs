using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator anim;

    private Rigidbody2D rb;

    private PhysicsCheck physicsCheck;

    private PlayerController playerController;
    private void Awake()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        physicsCheck = GetComponent<PhysicsCheck>();
        playerController = GetComponent<PlayerController>();
    }

    private void Update()
    {
        SetAnimation();
    }

    public void SetAnimation()
    {
        //调整动画器里面的参数，使下一个动作开始条件成立
        anim.SetFloat("velocityX", Mathf.Abs(rb.velocity.x));//将刚体中x值传递过来，作为动画的触发条件
        anim.SetFloat("velocityY", rb.velocity.y);
        anim.SetBool("isGround", physicsCheck.isGround);
        anim.SetBool("isCrouch", playerController.isCrouch);
        anim.SetBool("isDead", playerController.isDead);
        anim.SetBool("isAttack", playerController.isAttack);
        anim.SetBool("onWall", physicsCheck.onWall);
        anim.SetBool("isSlide", playerController.isSlide);
    }
    public void PlayHurt()
    {
        anim.SetTrigger("hurt");
    }

    public void PlayAttack()
    {
        anim.SetTrigger("attack");
    }
}
