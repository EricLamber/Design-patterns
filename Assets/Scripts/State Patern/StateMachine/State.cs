namespace StatePattern
{
    public abstract class State
    {
        protected Character _character;

        public State(Character character) => _character = character;

        public virtual void Enter() { }
        public virtual void Update() { }
        public virtual void Exit() { }
    }
}
