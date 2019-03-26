using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgentieDeTurismMpp.model;
using log4net;

namespace AgentieDeTurismMpp.repository
{
    class EmployeeRepository : IEmployeeRepository
    {
        private static readonly ILog log = LogManager.GetLogger("EmployeeRepository");
        public bool loginUser(Employee employee)
        {
            log.InfoFormat("Entered loginUser");
            SQLiteConnection connection = JDBCUtils.getConnection();
            var command = connection.CreateCommand();
            command.CommandText = "Select * from Angajati where Username=@username";
            IDbDataParameter parameter = command.CreateParameter();
            parameter.ParameterName = "@username";
            parameter.Value = employee.Username;
            command.Parameters.Add(parameter);
            log.InfoFormat("Preparing to execute query.");
            using (var dataR = command.ExecuteReader())
            {
                if (dataR.Read())
                {
                    string password = dataR.GetString(2);
                    if (employee.Password != password)
                    {
                        log.InfoFormat("password incorrect!");
                        //throw new RepositoryException("password incorrect!");
                        return false;
                    }

                    log.InfoFormat("query finished successfuly.");
                    return true;
                }
                return false;
            }
        }
                public void add(Employee t)
        {
            throw new NotImplementedException();
        }

        public void delete(Employee t)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> findAll()
        {
            throw new NotImplementedException();
        }

        public void update(Employee t)
        {
            throw new NotImplementedException();
        }
    }
}
