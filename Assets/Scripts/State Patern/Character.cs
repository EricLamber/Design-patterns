using System.Collections;
using UnityEngine;

namespace StatePattern
{
    public class Character : MonoBehaviour
    {
        public float _energy = 10;
        public float _fadeDuration = 2;
        public Transform _sittingtrget;
        public Renderer _renderer;

        [SerializeField] private Material _opaqueMaterial;
        [SerializeField] private Material _fadeMaterial;
        [SerializeField] private float _minEnergy = 0;
        [SerializeField] private float _maxEnergy = 10;

        [HideInInspector] public Animator _animator;
        [HideInInspector] public bool IsDancing = false;
        [HideInInspector] public bool IsSitting = false;

        private StateMachine _stateMachine;

        private void Start()
        {
            _animator = GetComponent<Animator>();
            _stateMachine = new StateMachine(new IdleState(this));
        }

        private void Update()
        {
            _stateMachine.CurrentState.Update();

            if (_energy >= _maxEnergy && !IsDancing)
                _stateMachine.ChangeState(new DanceState(this));
            else if (_energy <= _minEnergy && !IsSitting)
                _stateMachine.ChangeState(new SittingState(this));
        }


        //Yeah, bettrer make it in another script, but this project about patterns. Pay atantion on pattern :)
        public IEnumerator FadingIn(float duration)
        {
            _renderer.material = _fadeMaterial;
            var color = _renderer.material.color;
            var currentAlfa = color.a;
            var startAlfa = currentAlfa;
            var t = 0f;

            while (t < duration)
            {
                t += Time.deltaTime;
                var blend = Mathf.Clamp01(t / duration);
                color.a = Mathf.Lerp(startAlfa, 0f, blend);
                _renderer.material.color = color;
                yield return null;
            }
        }

        public IEnumerator FadingOut(float duration)
        {
            var color = _renderer.material.color;
            var currentAlfa = color.a;
            var startAlfa = currentAlfa;
            var t = 0f;

            while (t < duration)
            {
                t += Time.deltaTime;
                var blend = Mathf.Clamp01(t / duration);
                color.a = Mathf.Lerp(startAlfa, color.maxColorComponent, blend);
                _renderer.material.color = color;
                yield return null;
            }
            _renderer.material = _opaqueMaterial;
        }
    }
}
