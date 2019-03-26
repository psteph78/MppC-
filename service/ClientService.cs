using AgentieDeTurismMpp.model;
using AgentieDeTurismMpp.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentieDeTurismMpp.service
{
    class ClientService
    {
        ClientRepository repository = new ClientRepository();

        public int findClient(Client client) { return repository.findOne(client); }
    }
}
