using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentieDeTurismMpp.model
{
    class Client
    {
        private string firstName;
        private string lastName;
        private string telephoneNr;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string TelephoneNr
        {
            get { return telephoneNr; }
            set { telephoneNr = value; }
        }

        public Client(string firstName, string lastName, string telephoneNr)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.telephoneNr = telephoneNr;
        }

    }
}
