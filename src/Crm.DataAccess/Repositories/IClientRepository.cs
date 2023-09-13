namespace Crm.DataAccess;

public interface IClientRepository 
{
    public ClientInfo CreateClient(ClientInfo clientInfo);
    public ClientInfo GetClient(string firstName, string lastName);
    public bool RemoveClient(string firstName, string lastName);
    Client GetById(int clientId);
    List<Client> GetAll();
}