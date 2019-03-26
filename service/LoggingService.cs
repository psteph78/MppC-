using AgentieDeTurismMpp.model;
using AgentieDeTurismMpp.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentieDeTurismMpp.service
{
    class LoggingService
    {
        private EmployeeRepository repository = new EmployeeRepository();
        
        public bool loginUser(Employee employee) { return repository.loginUser(employee); }
    }
}
