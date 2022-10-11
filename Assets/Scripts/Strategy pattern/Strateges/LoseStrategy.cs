using UnityEngine;

namespace StrategyPattern
{
    public class LoseStrategy : ILose
    {
        private readonly Animator _animator;

        public LoseStrategy(Animator animator) => _animator = animator;

        public void Lose()
        {
            _animator.SetTrigger("Death");
        }
    }
}