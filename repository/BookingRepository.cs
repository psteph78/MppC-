using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgentieDeTurismMpp.model;
using log4net;

namespace AgentieDeTurismMpp.repository
{
    class BookingRepository : IBookingRepository
    {
        private static readonly ILog log = LogManager.GetLogger("BookingRepository");
        public void addBooking(int idClient, int idExcursion, int nrTickets)
        {
            log.InfoFormat("Entered addBooking");
            //using (SQLiteConnection connection = JDBCUtils.getConnection())
            //{
            //    try
            //    {
            //        string query = "Insert into Rezervari(IDClient, IDExcursie, NrTickets) values(@idClient,@idExcursion,@nrTickets)";
            //        SQLiteCommand command = new SQLiteCommand(query, connection);
            //        command.Parameters.AddWithValue("@idClient", idClient);
            //        command.Parameters.AddWithValue("@idExcursion", idExcursion);
            //        command.Parameters.AddWithValue("@nrTickets", nrTickets);

            //        log.InfoFormat("Preparing to execute query.");
            //        int successful = command.ExecuteNonQuery();

            //        if (successful == -1)
            //        {
            //            log.InfoFormat("Couldn't add record to database.");
            //        }
            //        else
            //        {
            //            log.InfoFormat("Query finished successfuly.");
            //        }
            //        //connection.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        //connection.Close();
            //        log.InfoFormat("Exception thrown!");
            //        Console.WriteLine(ex.StackTrace);
            //    }
            //}
            SQLiteConnection connection = JDBCUtils.getConnection();
            string query = "Insert into Rezervari(IDClient, IDExcursie, NrTickets) values(@idClient,@idExcursion,@nrTickets)";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@idClient", idClient);
            command.Parameters.AddWithValue("@idExcursion", idExcursion);
            command.Parameters.AddWithValue("@nrTickets", nrTickets);

            log.InfoFormat("Preparing to execute query.");
            int successful = command.ExecuteNonQuery();

            if (successful == -1)
            {
                log.InfoFormat("Couldn't add record to database.");
            }
            else
            {
                log.InfoFormat("Query finished successfuly.");
            }
        }

        public void deleteBooking(int idClient, int idExcursion)
        {
            log.InfoFormat("Entered deleteBooking");
            //using (SQLiteConnection connection = JDBCUtils.getConnection())
            //{
            //    try
            //    {
            //        string query = "Delete from Rezervari where IDClient = @idClient and IDExcursie = @idExcursion";
            //        SQLiteCommand command = new SQLiteCommand(query, connection);
            //        command.Parameters.AddWithValue("@idClient", idClient);
            //        command.Parameters.AddWithValue("@idExcursion", idExcursion);

            //        log.InfoFormat("Preparing to execute query.");
            //        int successful = command.ExecuteNonQuery();

            //        if (successful == -1)
            //        {
            //            log.InfoFormat("Couldn't delete record to database.");
            //        }
            //        else
            //        {
            //            log.InfoFormat("Query finished successfuly.");
            //        }
            //        //connection.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        //connection.Close();
            //        log.InfoFormat("Exception thrown!");
            //        Console.WriteLine(ex.StackTrace);
            //    }
            //}
            SQLiteConnection connection = JDBCUtils.getConnection();
            string query = "Delete from Rezervari where IDClient = @idClient and IDExcursie = @idExcursion";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@idClient", idClient);
            command.Parameters.AddWithValue("@idExcursion", idExcursion);

            log.InfoFormat("Preparing to execute query.");
            int successful = command.ExecuteNonQuery();

            if (successful == -1)
            {
                log.InfoFormat("Couldn't delete record to database.");
            }
            else
            {
                log.InfoFormat("Query finished successfuly.");
            }
        }

        public void add(Booking t)
        {
            throw new NotImplementedException();
        }

        public void delete(Booking t)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Booking> findAll()
        {
            throw new NotImplementedException();
        }

        public void update(Booking t)
        {
            throw new NotImplementedException();
        }
    }
}
