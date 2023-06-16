namespace StateMachine;

public class LoadFileCommand : ICommand
{
    public string Path { get; set; } = "../SaveFiles/";
    string SaveName { get; set; } = "save1.txt";
    public LoadFileCommand(string path, string saveFile)
    {
        Path = path;
        SaveName = saveFile;
    }
    public void Execute()
    {
        WriteLine("The save files in the directory are:");
        string[] files = ReadDirectory();
        if (string.IsNullOrWhiteSpace(files[0]))
        {
            WriteLine("There are no save game files.");
            ReadKey();
            return;
        }
        PrintFiles(files);
        string userChoice = StateManager.GetText("Choose the file name to load: ");
        SaveName = userChoice;
        string fullPath = Path + SaveName;
        if (!File.Exists(fullPath))
        {
            WriteLine("File doesn't exist.");
            ReadKey();
            return;
        }
        ReadFile(fullPath);
        ReadKey();
    }
    public string[] ReadDirectory()
    {
        string[] files;
        if (!Directory.Exists(Path))
        {
            Directory.CreateDirectory(Path);
        }
        else
        {
            try
            {
                return files = Directory.GetFiles(Path);
            }
            catch (Exception)
            {
                throw;
            }
        }
        files = new string[] {""};
        return files;
    }
    public void PrintFiles(string[] files)
    {
        foreach (string file in files)
        {
            WriteLine(file);
        }
    }
    public void ReadFile(string path)
    {
        try
        {
            using StreamReader stream = File.OpenText(path);
            while (stream.Peek() >= 0)
            {
                WriteLine(stream.ReadLine());
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
}
