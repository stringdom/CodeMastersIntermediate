namespace StateMachine;

// Defines the State Interface
public interface IState
{
    public abstract void Render();
    public abstract ICommand GetCommand(StateManager manager);
}