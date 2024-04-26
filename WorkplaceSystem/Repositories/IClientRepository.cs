using WorkplaceSystem.Models;

namespace WorkplaceSystem.Repositories
{
    public interface IClientRepository
    {
        public ClientModel AddClient(ClientModel client);
        public List<ClientModel> FindAllClients();
        public ClientModel FindById(int id);
        public ClientModel DisableClient(ClientModel client);
        public ClientModel UpdateClient(ClientModel client);
    }
}
