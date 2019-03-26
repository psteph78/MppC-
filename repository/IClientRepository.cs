using AgentieDeTurismMpp.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentieDeTurismMpp.repository
{
    interface IClientRepository : IRepository<Client>
    {
        int findOne(Client client);
    }
}
