using Internal;

public interface IUserInterface
{
    void DisplayMessage(string message);
    string GetInput();
}

public class ConsoleUserInterface : IUserInterface
{
    public void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }

    public string GetInput()
    {
        return Console.ReadLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
       
        IUserInterface userInterface = new ConsoleUserInterface();
        CommunicatingClass game = new CommunicatingClass();
        game.OnGetPlayerAction += () => { userInterface.GetInput(); };
        game.OnInformPlayer += userInterface.DisplayMessage;
        game.InformPlayer("Welcome to the game!");
        game.GetPlayerAction();
    }
}
