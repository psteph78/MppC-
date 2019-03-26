using AgentieDeTurismMpp.model;
using AgentieDeTurismMpp.service;
using AgentieDeTurismMpp.validator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgentieDeTurismMpp.view
{
    public partial class SearchExcursions : Form
    {
        private ExcursionService excursionService = new ExcursionService();
        private ClientService clientService = new ClientService();
        private BookingService bookingService = new BookingService();
        private BookingValidator bookingValidator = new BookingValidator();
        private Excursion selectedExcursion;

        public Excursion SelectedExcursion
        {
            get { return selectedExcursion; }
            set { selectedExcursion = value; }
        }
        public SearchExcursions()
        {
            InitializeComponent();
            List<Excursion> allExcursions = excursionService.findAllExcursions();
            loadTable(allExcursions);
        }

        private void loadTable(List<Excursion> excursions)
        {
            dataGrid.AutoGenerateColumns = false;
            dataGrid.AllowUserToAddRows = false;
            dataGrid.DataSource = excursions;

            dataGrid.Columns.Add("Landmark", "Landmark");
            dataGrid.Columns.Add("LeavingHour", "Leaving Hour");
            dataGrid.Columns.Add("AvailablePlaces", "Available Places");
            dataGrid.Columns.Add("TransportCompany", "Transport Company");
            dataGrid.Columns.Add("Price", "Price");

            dataGrid.Columns[0].DataPropertyName = "landmark";
            dataGrid.Columns[1].DataPropertyName = "leavingHour";
            dataGrid.Columns[2].DataPropertyName = "availablePlaces";
            dataGrid.Columns[3].DataPropertyName = "transportCompany";
            dataGrid.Columns[4].DataPropertyName = "price";

            colorSoldOutRows();
        }

        private void bookExcursion(object sender, EventArgs e)
        {
            string lastName = lastNameField.Text;
            string firstName = firstNameField.Text;
            string telephoneNr = telephoneNrField.Text;

            Client client = new Client(firstName, lastName, telephoneNr);
            int idClient = clientService.findClient(client);
            int nrTickets = Int32.Parse(nrTicketsField.Text);

            bool checkTransaction = bookingValidator.validTransaction(SelectedExcursion.Landmark, selectedExcursion.LeavingHour, nrTickets);

            if (checkTransaction)
            {
                int idExcursion = excursionService.findExcursion(SelectedExcursion.Landmark, SelectedExcursion.LeavingHour);
                bookingService.addBooking(idClient, idExcursion, nrTickets);
                excursionService.updateTickets(idExcursion, nrTickets);
                searchExcursion();
            }
            else
            {
                bookingNotifyBox.Text = "Transaction couldn't be carried out. There are not enough available places.";
            }
        }

        private void searchExcursion()
        {
            string landmark = landmarkField.Text;
            int startInterval = Int32.Parse(beginTimeInterval.Text);
            int endInterval = Int32.Parse(endTimeInterval.Text);

            List<Excursion> excursions = excursionService.findExcursions(landmark, startInterval, endInterval);
            loadTable(excursions);
        }

        private void searchExcursionOnClick(object sender, EventArgs e)
        {
            searchExcursion();
        }

        private void logOut(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.ShowDialog();
        }

        private void updateSelectedExcursion(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGrid.Rows[e.RowIndex];
                string landmark = row.Cells["Landmark"].Value.ToString();
                int leavingHour = Int32.Parse(row.Cells["LeavingHour"].Value.ToString());
                int availablePlaces = Int32.Parse(row.Cells["AvailablePlaces"].Value.ToString());
                string transportCompnay = row.Cells["TransportCompany"].Value.ToString();
                double price = Double.Parse(row.Cells["Price"].Value.ToString());

                Excursion ex = new Excursion(landmark, leavingHour, availablePlaces, transportCompnay, price);
                SelectedExcursion = ex;
            }
        }

        private void colorSoldOutRows()
        {
            for (int i = 0; i < dataGrid.Rows.Count; i++)
            {
                int val = Int32.Parse(dataGrid.Rows[i].Cells["AvailablePlaces"].Value.ToString());
                if (val == 0)
                {
                    dataGrid.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }
    }
}
