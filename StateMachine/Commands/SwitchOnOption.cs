namespace StateMachine;

public class SwitchOnOption : ICommand
{
public IState InputState { get; set; }
public StateManager Manager {get;set;}
public SwitchOnOption(IState input, StateManager manager)
{
  InputState = input;
  Manager = manager;
}
public void Execute()
{
  Manager.ProgramState = InputState;
}
}