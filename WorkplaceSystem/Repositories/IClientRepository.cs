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
        public UseModel AddUse(UseModel use, int id);
        public List<UseModel> FindAllUses();
        public UseModel FindUseById(int id);
    }
}
