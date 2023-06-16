namespace StateMachine;

public class ExitGame : IState
{
    public void Render()
    {
        Clear();
        WriteLine("Thanks for playing!");
        ReadKey();
    }
    public ICommand GetCommand(StateManager manager)
    {
        return new ExitGameCommand();
    }
}
