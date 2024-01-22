
public class CommunicatingClass
{
   
    public delegate void GetPlayerActionDelegate();

    
    public delegate void InformPlayerDelegate(string message);

  
    public event GetPlayerActionDelegate OnGetPlayerAction;
    public event InformPlayerDelegate OnInformPlayer;

    
    protected void GetPlayerAction()
    {
        OnGetPlayerAction?.Invoke();
    }

    // Méthode pour envoyer une information au joueur
    protected void InformPlayer(string message)
    {
        OnInformPlayer?.Invoke(message);
    }
}
