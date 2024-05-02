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
            ClientModel client = _clientRepository.FindById(Id);
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
            if (ModelState.IsValid)
            {
                _clientRepository.AddClient(client);
                return RedirectToAction("Index");
            }

            return View(client);
        }
        [HttpPost]
        public IActionResult UpdateClient(ClientModel client)
        {
            if (ModelState.IsValid)
            {
                _clientRepository.UpdateClient(client);
                return RedirectToAction("Index");
            }
            return View(client);
        }

        public IActionResult PrintPage(int id)
        {
            UseModel use = _clientRepository.FindUseById(id);
            ClientModel client = _clientRepository.FindById(use.ClientId);

            return View(use);
        }

        public IActionResult ClientDetails(int id, FilterModel filter)
        {
            ClientModel client = _clientRepository.FindById(filter.Id);
            client.ClientUses = _clientRepository.FindUsesByDate(filter.Id, filter.StartDate, filter.EndDate);

            return View(client);
        }

        public IActionResult AddUse(int id)
        {
            ClientModel client = _clientRepository.FindById(id);
            UseModel use = new UseModel();
            use.ClientId = client.Id;
            return View(use);
        }

        [HttpPost]
        public IActionResult AddNewUse(UseModel use, int Id)
        {
            _clientRepository.AddUse(use, Id);
            return RedirectToAction("Index");
        }

        public IActionResult Filter(int id, DateTime start, DateTime end)
        {
            return View();
        }
    }
}
