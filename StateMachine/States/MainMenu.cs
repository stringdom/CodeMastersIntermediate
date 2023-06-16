namespace StateMachine;

// Implements the Main menu State
public class MainMenu : IState
{
    public void Render()
    {
        Clear();
        Console.WriteLine("This is the main menu.");
    }
    public ICommand GetCommand(StateManager manager)
    {
        string input = StateManager.GetText("What do you want to do? ");
        return new SwitchOnOption(new LoadFile(), manager);
    }
}