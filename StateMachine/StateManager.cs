using static System.Console;

namespace StateMachine;

// Implements the State handling
class StateManager
{
    readonly string _invalidInput = "That is not an option.";
    public static string InvalidInput
    {
        get {return _invalidInput;}
    }
    private IState _state;
    public StateManager (IState state)
    {
        _state = state;
    }
    public void Run(IState initialState)
    {
        _state = initialState;
        while (true)
        {
            _state.Render();
            var command = _state.GetCommand(this);
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