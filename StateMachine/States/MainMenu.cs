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
        if (input.ToLower().Contains("save"))
        {
            return new SwitchOnOption(new SaveFile(), manager);
        }
        else if (input.ToLower().Contains("load"))
        {
            return new SwitchOnOption(new LoadFile(), manager);
        }
        else
        {
            return new SwitchOnOption(this, manager);
        }
    }
}