namespace StateMachine;

// Implements the State handling
class StateManager
{
    private IState _state;
    public StateManager (IState state)
    {
        _state = state;
    }
    public void Run(IState state)
    {
        
    }
}