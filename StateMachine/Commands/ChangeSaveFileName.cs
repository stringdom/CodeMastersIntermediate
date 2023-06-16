namespace StateMachine;

public class ChangeSaveFileName : ICommand
{
    public IFileOperator File{ get; set;}
    public ChangeSaveFileName(IFileOperator file)
    {
        File = file;
    }
    public void Execute()
    {
        File.SetParameter(StateManager.GetText("Write the new filename: "));
    }
}
