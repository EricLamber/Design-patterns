using UnityEngine;

namespace StrategyPattern
{
    public class Girl : Fighter
    {
        private const string _vampire = "Vampire";

        void Start()
        {
            var anim = GetComponent<Animator>();
            SetBolck(new BlockStrategy(anim));
            SetIdle(new IdleStrategy(anim));
            SetSpecial(new SpecialPunchBagStrategy(anim));
            SetPunch(new PunchStrategy(anim));
            SetLose(new LoseStrategy(anim));
        }


        void OnTriggerEnter(Collider other)
        {
            if(other.CompareTag(_vampire))
            Debug.Log("Paw!!");
        }
    }
}
