using AgentieDeTurismMpp.model;
using AgentieDeTurismMpp.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentieDeTurismMpp.service
{
    class ExcursionService
    {
        ExcursionRepository repository = new ExcursionRepository();
        
        public List<Excursion> findExcursions(String landmark, int beginTimeInterval, int endTimeInterval) { return repository.findExcursions(landmark, beginTimeInterval, endTimeInterval); }
        public List<Excursion> findAllExcursions() { return repository.findAllExcursions(); }
        public int findAvailablePlaces(string landmark, int leavingHour) { return repository.findAvailablePlaces(landmark, leavingHour); }
        public void updateTickets(int idExcursion, int nrTickets) { repository.updateTickets(idExcursion, nrTickets); }
        public int findExcursion(string landmark, int leavingHour) { return repository.findOne(landmark, leavingHour);  }
    }
}
