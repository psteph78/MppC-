using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentieDeTurismMpp.model
{
    class Booking
    {
        private int clientID;
        private int excursionID;
        private int nrTickets;

        public int ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }

        public int ExcursionID
        {
            get { return excursionID; }
            set { excursionID = value; }
        }

        public int NrTickets
        {
            get { return nrTickets; }
            set { nrTickets = value; }
        }

        public Booking(int clientID, int excursionID, int nrTickets)
        {
            this.clientID = clientID;
            this.excursionID = excursionID;
            this.nrTickets = nrTickets;
        }
    }
}

