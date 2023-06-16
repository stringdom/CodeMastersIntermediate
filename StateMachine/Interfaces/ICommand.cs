namespace StateMachine;

interface ICommand
{
    IState Execute();
}