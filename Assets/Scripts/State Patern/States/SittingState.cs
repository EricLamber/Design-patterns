using UnityEngine;

namespace StatePattern
{
    public class SittingState : State
    {
        private const string AnimName = "Sitting";

        public SittingState(Character character) : base(character) { }

        public override void Enter()
        {
            _character.IsSitting = true;
            _character.transform.SetPositionAndRotation(_character._sittingtrget.position, _character._sittingtrget.rotation);
            _character._animator.Play(AnimName);
            _character.StartCoroutine(_character.FadingOut(_character._fadeDuration));
        }

        public override void Update()
        {
            _character._energy += Time.deltaTime;
        }

        public override void Exit()
        {
            _character.IsSitting = false;
            _character.StartCoroutine(_character.FadingIn(_character._fadeDuration));
        }
    }
}
