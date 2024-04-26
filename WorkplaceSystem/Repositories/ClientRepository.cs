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
    }
}
