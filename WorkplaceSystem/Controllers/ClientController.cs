using Microsoft.AspNetCore.Mvc;
using WorkplaceSystem.Models;
using WorkplaceSystem.Repositories;

namespace WorkplaceSystem.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientRepository _clientRepository;
        public ClientController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public IActionResult Index()
        {
            List<ClientModel> client = _clientRepository.FindAllClients();
            return View(client);
        }

        public IActionResult AddClient()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddClient(ClientModel client)
        {
            _clientRepository.AddClient(client);
            return RedirectToAction("Index");
        }
    }
}
