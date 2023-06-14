namespace AppSingleton.Command;

public class RemoteControl
{
    private readonly ICommand _command;

    public RemoteControl(ICommand command)
    {
        _command = command;
    }

    public void PressButton()
    {
        _command.Execute();
    }
}