using StateMachine;
namespace ElfinLibrary;

public class ElfinLibrary
{
    public static void Main()
    {
        var stateManager = new StateManager(new MainMenu());
        stateManager.Run();
    }
}