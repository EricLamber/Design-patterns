using UnityEngine;

namespace StrategyPattern
{
    public class IdleStrategy : IIdle
    {
        private readonly Animator _animator;

        public IdleStrategy(Animator animator) => _animator = animator;
             
        public void Idle()
        {
            _animator.Play("Idle");
        }
    }
}
