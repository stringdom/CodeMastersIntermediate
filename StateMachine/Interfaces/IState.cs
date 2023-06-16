namespace StateMachine;

// Defines the State Interface
interface IState
{
    abstract void Render();
    abstract ICommand GetCommand(StateManager manager);
}
