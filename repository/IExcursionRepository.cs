using AgentieDeTurismMpp.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentieDeTurismMpp.repository
{
    interface IExcursionRepository: IRepository<Excursion>
    {
        List<Excursion> findExcursions(string landmark, int beginTimeInterval, int endTimeInterval);
        List<Excursion> findAllExcursions();
        int findAvailablePlaces(string landmark, int leavingHour);
        void updateTickets(int idExcursion, int nrTickets);
        int findOne(string landmark, int leavingHour);
    }
}
