namespace StateMachine;

public class ChangeSaveFileName : ICommand
{
    public SaveFile File{ get; set;}
    public ChangeSaveFileName(SaveFile file)
    {
        File = file;
    }
    public void Execute()
    {
        File.SaveName = StateManager.GetText("Write the new filename: ");
    }
}
