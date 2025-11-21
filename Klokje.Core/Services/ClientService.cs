using Klokje.Core.Interfaces.Repositories;
using Klokje.Core.Interfaces.Services;
using Klokje.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klokje.Core.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public Client? Get(string email)
        {
            return _clientRepository.Get(email);
        }

        public Client? Get(int id)
        {
            return _clientRepository.Get(id);
        }

        public List<Client> GetAll()
        {
            List<Client> clients = _clientRepository.GetAll();
            return clients;
        }
    }
}
