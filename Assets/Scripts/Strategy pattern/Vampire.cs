using UnityEngine;

namespace StrategyPattern
{
    public class Vampire : Fighter
    {
        private const string _girl = "Girl";

        void Start()
        {
            var anim = GetComponent<Animator>();
            SetBolck(new BlockStrategy(anim));
            SetIdle(new IdleStrategy(anim));
            SetSpecial(new SpecialElbowStrategy(anim));
            SetPunch(new PunchStrategy(anim));
            SetLose(new LoseStrategy(anim));
        }


        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag(_girl))
                Debug.Log("Poow!!");
        }
    }
}
