namespace StateMachine;

public class LoadFile : IState, IFileOperator
{
    string Path { get; set; } = "../SaveFiles/";
    string SaveName { get; set; } = "save1.txt";
    public void Render()
    {
        Clear();
        WriteLine("Reading files on {0}.", Path);
    }
    public ICommand GetCommand(StateManager manager)
    {
        string input = StateManager.GetText("What do you want to do? ");
        return input.ToLower() switch
        {
            "load" => new LoadFileCommand(Path, SaveName),
            "change" => new ChangeSaveFileName(this),
            _ => new SwitchOnOption( new MainMenu(), manager),
        };
    }
    public void SetParameter(string text)
    {
        Path = text;
    }
}