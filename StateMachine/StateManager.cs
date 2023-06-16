using static System.Console;

namespace StateMachine
{
    // Implements the State handling
    public class StateManager
    {
        public static string InvalidInput { get; } = "That is not an option.";
        private IState _state;
        public StateManager(IState state)
        {
            if (state == null)
            {
                _state = new MainMenu();
            }
            else
            {
                _state = state;
            }
        }
        public IState ProgramState
        {
            get{ return _state; }
            set{_state = value; }
        }
        public void Run(IState initialState)
        {
            _state = initialState;
            while (true)
            {
                _state.Render();
                var command = _state.GetCommand(this);
                command.Execute();
            }
        }
        public static string GetText(string prompt)
        {
            string? input = null;
            while (string.IsNullOrWhiteSpace(input))
            {
                Write(prompt);
                input = ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    WriteLine(StateManager.InvalidInput);
                }
            }
            return input;
        }
    }
}