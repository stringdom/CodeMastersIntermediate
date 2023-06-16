namespace StateMachine;

public class Help : ICommand
{
    public void Execute()
    {
        Clear();
        WriteLine("""
        Welcome to the Elfin Library.
        -----------------------------
        Type in the console the commands.

        You can start a [New Game], or [Load] a previously saved game.
        You can always [Save] your game at any point.
        [Back] will always return you to the previous screen.

        At any point you can [Exit] to quit this game.
        """ 
        );
        ReadKey();
    }
}
