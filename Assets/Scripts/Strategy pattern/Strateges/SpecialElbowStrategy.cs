using UnityEngine;

namespace StrategyPattern
{
    public class SpecialElbowStrategy : ISpecial
    {
        private readonly Animator _animator;

        public SpecialElbowStrategy(Animator animator) => _animator = animator;

        public void Special()
        {
            _animator.SetTrigger("ElbowPunch");
        }
    }
}
