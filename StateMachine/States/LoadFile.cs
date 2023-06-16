namespace StateMachine;

public class LoadFile : IState
{
    string Path { get; set; } = "../SaveFiles/";
    string SaveName { get; set; } = "save1.txt";
    public void Render()
    {
        Clear();
        WriteLine("Reading file on {0}{1}.", Path, SaveName);
    }
    public ICommand GetCommand(StateManager manager)
    {
        string input = StateManager.GetText("What do you want to do? ");
        return new SwitchOnOption(new MainMenu(), manager);
    }
}