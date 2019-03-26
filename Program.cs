using AgentieDeTurismMpp.view;
using AgentieDeTurismMpp.model;
using AgentieDeTurismMpp.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgentieDeTurismMpp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            log4net.Config.XmlConfigurator.Configure();
            EmployeeRepository repo = new EmployeeRepository();
            Employee employee = new Employee("steph", "1234");
            //repo.loginUser(employee);

            ClientRepository client = new ClientRepository();
            Client cl = new Client("Pricop", "Stefania", "0746848443");
            //int res = client.findOne(cl);
            //Console.WriteLine(res);

            ExcursionRepository excursion = new ExcursionRepository();
            //excursion.updateTickets(1, -20);
            BookingRepository booking = new BookingRepository();
            //booking.deleteBooking(1, 1);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Application.Run(new Main());
        }
    }
}
