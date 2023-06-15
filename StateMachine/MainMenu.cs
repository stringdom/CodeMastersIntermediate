namespace StateMachine;

// Implements the Main menu State
public class MainMenu : IState
{
    public void Render()
    {
        Console.WriteLine("This is the main menu.");
    }
    public void GetCommand()
    {

    }
}