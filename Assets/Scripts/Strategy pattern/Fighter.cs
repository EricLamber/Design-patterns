using UnityEngine;


namespace StrategyPattern
{
    public class Fighter : MonoBehaviour
    {
        [SerializeField] protected byte _health = 5;

        protected IBlock _block;
        protected IPunch _punch;
        protected ISpecial _special;
        protected IIdle _idle;
        protected ILose _lose;

        #region SetStrategy
        public void SetBolck(IBlock block) => _block = block;
        public void SetPunch(IPunch punch) => _punch = punch;
        public void SetSpecial(ISpecial special) => _special = special;
        public void SetIdle(IIdle idle) => _idle = idle;
        public void SetLose(ILose lose) => _lose = lose;

        #endregion

        #region BaseMethods

        protected void Block() => _block.Block();
        protected void Punch() => _punch.Punch();
        protected void Special() => _special.Special();
        protected void Idle() => _idle.Idle();
        protected void Lose() => _lose.Lose();

        #endregion
    }
}
