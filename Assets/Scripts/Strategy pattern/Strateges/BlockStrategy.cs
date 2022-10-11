using UnityEngine;

namespace StrategyPattern
{
    public class BlockStrategy : IBlock
    {
        private readonly Animator _animator;

        public BlockStrategy(Animator animator) => _animator = animator;

        public void Block()
        {
            _animator.SetTrigger("Block");
        }
    }
}
