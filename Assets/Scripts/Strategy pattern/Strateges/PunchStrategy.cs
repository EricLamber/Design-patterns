using UnityEngine;

namespace StrategyPattern
{
    public class PunchStrategy : IPunch
    {
        private readonly Animator _animator;

        public PunchStrategy(Animator animator) => _animator = animator;

        public void Punch()
        {
            _animator.SetTrigger("Punch");
        }
    }
}
