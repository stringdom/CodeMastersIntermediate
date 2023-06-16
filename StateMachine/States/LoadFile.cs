using static System.Console;
namespace StateMachine
{
    class LoadFile : IState
    {
        string Path { get; set; } = "save1.json";
        public void Render()
        {
            Clear();
            WriteLine("Writing a new File.");
        }
        public ICommand GetCommand(StateManager manager)
        {
            // string input = StateManager.GetText("What do you want to do? ");
            return new SwitchOnOption(new MainMenu(), manager);
        }
    }
}