namespace StateMachine;

public class ExitGameCommand : ICommand
{
    public void Execute()
    {
        Environment.Exit(0);
    }
}
