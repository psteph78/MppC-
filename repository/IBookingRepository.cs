using AgentieDeTurismMpp.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentieDeTurismMpp.repository
{
    interface IBookingRepository : IRepository<Booking>
    {
        void addBooking(int idClient, int idExcursion, int nrTickets);
        void deleteBooking(int idClient, int idExcursion);
    }
}
