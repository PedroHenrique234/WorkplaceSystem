using WorkplaceSystem.Data;
using WorkplaceSystem.Models;

namespace WorkplaceSystem.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly BankContext _bankContext;
        public ClientRepository(BankContext bankContext)
        {
            _bankContext = bankContext;
        }
        public ClientModel AddClient(ClientModel client)
        {
            _bankContext.Clients.Add(client);   
            _bankContext.SaveChanges();
            return client;
        }
        public ClientModel DisableClient(ClientModel client)
        {
            ClientModel clientDb = new ClientModel();

            if (client == null) throw new Exception("Impossível desativar o cliente");

            client.Situation = false;

            clientDb.Id = client.Id;
            clientDb.Situation = client.Situation;
            clientDb.Name = client.Name;
            clientDb.PhoneNumber = client.PhoneNumber;
            clientDb.CreateDate = client.CreateDate;

            _bankContext.Update(clientDb);
            _bankContext.SaveChanges();
            return clientDb;
        }

        public ClientModel UpdateClient(ClientModel client)
        {
            ClientModel clientDb = new ClientModel();

            if (client == null) throw new Exception("Impossível desativar o cliente");

            clientDb.Id = client.Id;
            clientDb.Situation = client.Situation;
            clientDb.Name = client.Name;
            clientDb.PhoneNumber = client.PhoneNumber;
            clientDb.CreateDate = client.CreateDate;

            _bankContext.Update(clientDb);
            _bankContext.SaveChanges();
            return clientDb;
        }

        public List<ClientModel> FindAllClients()
        {
            List<ClientModel> client = _bankContext.Clients.ToList();
            return client;
        }
        public ClientModel FindById(int id)
        {
            return _bankContext.Clients.FirstOrDefault(x => x.Id == id);
        }
    }
}
