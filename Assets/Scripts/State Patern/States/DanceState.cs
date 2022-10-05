using UnityEngine;

namespace StatePattern
{
    public class DanceState : State
    {
        private const string AnimName = "Dancing";

        public DanceState(Character character) : base(character) { }

        public override void Enter()
        {
            _character.IsDancing = true;
            _character.transform.SetPositionAndRotation(Vector3.zero, Quaternion.identity);
            _character._animator.Play(AnimName);
            _character.StartCoroutine(_character.FadingOut(_character._fadeDuration));
        }

        public override void Update()
        {
            _character._energy -= Time.deltaTime;
        }

        public override void Exit()
        {
            _character.IsDancing = false;
            _character.StartCoroutine(_character.FadingIn(_character._fadeDuration));
        }
    }
}
