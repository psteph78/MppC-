using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentieDeTurismMpp.repository
{
    public class RepositoryException : ApplicationException
    {
        public RepositoryException() { }
        public RepositoryException(String message) : base(message) { }
        public RepositoryException(String message, Exception e) : base(message, e) { }
    }

    interface IRepository<T>
    {
        void add(T t);
        void update(T t);
        void delete(T t);
        IEnumerable<T> findAll();
    }
}
