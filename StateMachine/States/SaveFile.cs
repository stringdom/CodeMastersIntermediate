namespace StateMachine;

public class SaveFile : IState, IFileOperator
{
    public string Path { get; set; } = "../SaveFiles/";
    public string SaveName { get; set; } = "save1.txt";
    public SaveFile()
    {
    }
    public SaveFile(string saveFileName)
    {
        SaveName = saveFileName;
    }
    public void Render()
    {
        Clear();
        WriteLine("The default path is: {0}", Path);
        WriteLine("You can [Save] your games to {0} from this screen.", SaveName);
        WriteLine("You can [Change] the save file name.");
    }
    public ICommand GetCommand(StateManager manager)
    {
        string input = StateManager.GetText("What do you want to do? ");
        return input.ToLower() switch
        {
            "save" => new SaveGame(Path, SaveName),
            "change" => new ChangeSaveFileName(this),
            _ => new SwitchOnOption( new MainMenu(), manager),
        };
    }
    public void SetParameter(string text)
    {
        SaveName = text;
    }
}
