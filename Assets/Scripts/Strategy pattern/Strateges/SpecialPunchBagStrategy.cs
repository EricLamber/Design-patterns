using UnityEngine;

namespace StrategyPattern
{
    public class SpecialPunchBagStrategy : ISpecial
    {
        private readonly Animator _animator;

        public SpecialPunchBagStrategy(Animator animator) => _animator = animator;

        public void Special()
        {
            _animator.SetTrigger("PunchBag");
        }
    }
}
