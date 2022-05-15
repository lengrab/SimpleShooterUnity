using System;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public abstract class EnemyAnimator : MonoBehaviour, IEnemyAnimate
{
    private Animator _animator;

    private static readonly int IsRunHash = Animator.StringToHash("IsRun");
    private static readonly int RunSpeedHash = Animator.StringToHash("RunSpeed");
    private static readonly int SimpleAttackHash = Animator.StringToHash("SimpleAttack");
    private static readonly int PowerAttackHash = Animator.StringToHash("PowerAttack");
    private static readonly int HitDamageHash = Animator.StringToHash("HitDamage");
    private static readonly int IsDeadHash = Animator.StringToHash("IsDead");
    
    #region Animations

    public void Idle()
    {
        _animator.SetFloat(RunSpeedHash,1);   
        _animator.SetBool(IsRunHash, false);  
        _animator.SetBool(IsDeadHash, false);  
    }

    public void Run(float speedAnimation)
    {
        _animator.SetFloat(RunSpeedHash,speedAnimation);   
        _animator.SetBool(IsRunHash, true);   
    }

    public void SimpleAttack()
    {
        _animator.SetTrigger(SimpleAttackHash);
    }

    public void PowerAttack()
    {
        _animator.SetTrigger(PowerAttackHash);
    }

    public void HitDamage()
    {
        _animator.SetTrigger(HitDamageHash);
    }

    public void Dead()
    {
        _animator.SetBool(IsDeadHash, true);   
    }
    #endregion
    
    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }
}
