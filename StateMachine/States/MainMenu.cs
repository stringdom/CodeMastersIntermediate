using System.Security.Cryptography.X509Certificates;

namespace StateMachine;

// Implements the Main menu State
public class MainMenu : IState
{
    public void Render()
    {
        Clear();
        WriteLine("This is the main menu.");
    }
    public ICommand GetCommand(StateManager manager)
    {
        string input = StateManager.GetText("What do you want to do? ");
        return input.ToLower() switch
        {
            "save" => new SwitchOnOption(new SaveFile(), manager),
            "load" => new SwitchOnOption(new LoadFile(), manager),
            "new game" => new SwitchOnOption(new NewGame(), manager),
            "exit" => new SwitchOnOption(new ExitGame(), manager),
            "help" => new Help(),
            _ => new SwitchOnOption(this, manager),
        };
    }
}