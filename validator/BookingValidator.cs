using AgentieDeTurismMpp.repository;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentieDeTurismMpp.validator
{
    class BookingValidator
    {
        private static readonly ILog log = LogManager.GetLogger("BookingValidator");
        private ExcursionRepository repository = new ExcursionRepository();

        public bool validTransaction(string landmark, int leavingHour, int nrTickets)
        {
            log.InfoFormat("Entered validTransaction.");
            log.InfoFormat("Obtaining total number of available places.");
            int totalTickets = repository.findAvailablePlaces(landmark, leavingHour);
            if (nrTickets > totalTickets)
            {
                log.InfoFormat("Transaction is invalid; there are not enough available places.");
                return false;
            }
            log.InfoFormat("Transaction is valid; there are enough available places.");
            return true;
        }

    }
}
