using Klokje.Core.Interfaces.Repositories;
using Klokje.Core.Models;
using System.Data;

namespace Klokje.Core.Data.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly List<Client> clientList;

        public ClientRepository()
        {
            clientList = new List<Client>
            {
                new Client(1, "Mark", "de", "Groot", new DateTime(1990, 1, 15), "employee@mail.com", "IunRhDKa+fWo8+4/Qfj7Pg==.kDxZnUQHCZun6gLIE6d9oeULLRIuRmxmH2QKJv2IM08=", 0, 40, 80),
                new Client(2, "H.H.", "", "Hermans", new DateTime(1985, 5, 20), "projectlead@mail.com", "dOk+X+wt+MA9uIniRGKDFg==.QLvy72hdG8nWj1FyL75KoKeu4DUgu5B/HAHqTD2UFLU=", 1, 40, 85),
                new Client(3, "A.J.", "", "Kwak", new DateTime(1980, 3, 10), "admin@mail.com", "sxnIcZdYt8wC8MYWcQVQjQ==.FKd5Z/jwxPv3a63lX+uvQ0+P7EuNYZybvkmdhbnkIHA=", 2, 40, 90)
            };
        }

        public Client? Get(string email)
        {
            Client? client = clientList.FirstOrDefault(c => c.Email.Equals(email));
            return client;
        }

        public Client? Get(int id)
        {
            Client? client = clientList.FirstOrDefault(c => c.Id == id);
            return client;
        }

        public List<Client> GetAll()
        {
            return clientList;
        }
    }
}
