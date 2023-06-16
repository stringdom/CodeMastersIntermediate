namespace StateMachine;

public class SaveGame : ICommand
{
    public string Path { get; set; } = "../SaveFiles/";
    string SaveName { get; set; } = "save1.txt";

    public SaveGame(string path, string saveFile)
    {
        Path = path;
        SaveName = saveFile;
    }
    public void Execute()
    {
        string fullPath = Path + SaveName;
        if (File.Exists(fullPath))
        {
            string answer = StateManager.GetText("File already exists, want to overwrite (y/n): ");
            if (answer.ToLower().Contains('n'))
            {
                return;
            }
        }
        WriteFile(fullPath);
        WriteLine("Game saved to {0}{1}", Path, SaveName);
        ReadKey();
    }
    public void WriteFile(string fullPath)
    {
        Directory.CreateDirectory(Path);
        try
        {
            using StreamWriter stream = File.CreateText(fullPath);
            stream.WriteLine("File was saved correctly.");
        }
        catch (Exception)
        {
            throw;
        }

    }
}
