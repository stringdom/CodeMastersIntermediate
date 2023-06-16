namespace StateMachine;

public class NewGame : IState
{
    public void Render()
    {
        Clear();
        WriteLine("Starting a New Game");
    }
    public ICommand GetCommand(StateManager manager)
    {
        ReadKey();
        return new SwitchOnOption(new MainMenu(), manager);
    }
}
