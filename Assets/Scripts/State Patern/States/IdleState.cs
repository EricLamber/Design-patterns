namespace StatePattern
{
    public class IdleState : State
    {
        private const string AnimName = "Idle";

        public IdleState(Character character) : base(character) { }

        public override void Enter()
        {
            _character.IsSitting = false;
            _character.IsDancing = false;
            _character._animator.Play(AnimName);
            _character.transform.SetPositionAndRotation(_character._sittingtrget.position, _character._sittingtrget.rotation);
            _character.StartCoroutine(_character.FadingOut(_character._fadeDuration));
        }

        public override void Exit()
        {
            _character.StartCoroutine(_character.FadingIn(_character._fadeDuration));
        }
    }
}
