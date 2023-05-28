
namespace BankingApp;

public class Client{
    private static int _clientcount = 0;
    public string Name { get; set; }
    public int ID { get; set; }
    public Client(string name)
    {
        Name = name;
        ID = ++_clientcount;
    }
}

public class ClientDirectory{
    public int Count {get; set;} = 0;
    private Dictionary<int, Client> clientList;

    public ClientDirectory(){
        clientList = new Dictionary<int, Client>();
    }
    public void AddClient(Client client){
        clientList.Add(client.ID, client);
    }

}


