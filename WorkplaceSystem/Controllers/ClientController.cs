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
        public IActionResult UpdateClient(int Id)
        {
            ClientModel client = _clientRepository.FindById(Id);
            return View(client);
        }
        public IActionResult DisableConfirm(int Id)
        {
            ClientModel client =_clientRepository.FindById(Id);
            return View(client);
        }
        [HttpPost]
        public IActionResult DisableClient(ClientModel client)
        {
            _clientRepository.DisableClient(client);
            return RedirectToAction("Index");   
        }

        [HttpPost]
        public IActionResult AddClient(ClientModel client)
        {
            _clientRepository.AddClient(client);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult UpdateClient(ClientModel client)
        {
            _clientRepository.UpdateClient(client);
            return RedirectToAction("Index");
        }
    }
}
