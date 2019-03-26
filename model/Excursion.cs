using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentieDeTurismMpp.model
{
    public class Excursion
    {
        private string landmark;
        private int leavingHour;
        private int availablePlaces;
        private string transportCompany;
        private double price;

        public string Landmark
        {
            get { return landmark; }
            set { landmark = value; }
        }

        public int LeavingHour
        {
            get { return leavingHour; }
            set { leavingHour = value; }
        }

        public int AvailablePlaces
        {
            get { return availablePlaces; }
            set { availablePlaces = value; }
        }

        public string TransportCompany
        {
            get { return transportCompany; }
            set { transportCompany = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Excursion(string landmark, int leavingHour, int availablePlaces, string transportCompany, double price)
        {
            this.landmark = landmark;
            this.leavingHour = leavingHour;
            this.availablePlaces = availablePlaces;
            this.transportCompany = transportCompany;
            this.price = price;
        }
    }
}
