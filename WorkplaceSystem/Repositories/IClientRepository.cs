using WorkplaceSystem.Models;

namespace WorkplaceSystem.Repositories
{
    public interface IClientRepository
    {
        public ClientModel AddClient(ClientModel client);
        public List<ClientModel> FindAllClients();
    }
}
