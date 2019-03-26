using AgentieDeTurismMpp.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentieDeTurismMpp.service
{
    class BookingService
    {
        BookingRepository repository = new BookingRepository();
        
        public void addBooking(int idClient, int idExcursion, int nrTickets) { repository.addBooking(idClient, idExcursion, nrTickets); }
        public void deleteBooking(int idClient, int idExcursion) { repository.deleteBooking(idClient, idExcursion); }
    }
}
