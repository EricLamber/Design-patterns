using System.Threading.Tasks;

namespace StatePattern
{
    public class StateMachine
    {
        public State CurrentState { get; private set; }

        public StateMachine(State startState)
        {
            CurrentState = startState;
            CurrentState.Enter();
        }

        public async void ChangeState(State newState)
        {
            CurrentState.Exit();
            await Task.Delay(1500);
            CurrentState = newState;
            CurrentState.Enter();
        }
    }
}
