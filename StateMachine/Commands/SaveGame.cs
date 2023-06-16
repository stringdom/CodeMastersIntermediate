namespace StateMachine;

public class SaveGame : ICommand
{
    string Path { get; set; } = "../SaveFiles/";
    string SaveName { get; set; } = "save1.txt";

    public SaveGame(string path, string saveFile)
    {
        Path = path;
        SaveName = saveFile;
    }
    public void Execute()
    {
        WriteLine("Game saved to {0}{1}", Path, SaveName);
        ReadKey();
    }
}
