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
    class ExcursionRepository : IExcursionRepository
    {
        private static readonly ILog log = LogManager.GetLogger("ExcursionRepository");

        public int findAvailablePlaces(string landmark, int leavingHour)
        {
            log.InfoFormat("Entered findAvailablePlaces");
            //using (SQLiteConnection connection = JDBCUtils.getConnection())
            //{
            //    try
            //    {
            //        string query = "Select AvailablePlaces from Excursii where (Landmark = @landmark) and (LeavingHour = @leavingHour)";
            //        SQLiteCommand command = new SQLiteCommand(query, connection);
            //        command.Parameters.AddWithValue("@landmark", landmark);
            //        command.Parameters.AddWithValue("@leavingHour", leavingHour);

            //        int availablePlaces = -1;
            //        log.InfoFormat("Preparing to execute query.");
            //        using (SQLiteDataReader reader = command.ExecuteReader())
            //        {
            //            if (reader.Read())
            //            {
            //                availablePlaces = reader.GetInt32(0);
            //            }

            //        }
            //        //connection.Close();
            //        log.InfoFormat("Query finished successfuly.");
            //        return availablePlaces;
            //    }
            //    catch (Exception ex)
            //    {
            //        //connection.Close();
            //        log.InfoFormat("Exception thrown!");
            //        Console.WriteLine(ex.StackTrace);
            //    }
            //    return -1;
            //}
            SQLiteConnection connection = JDBCUtils.getConnection();
            string query = "Select AvailablePlaces from Excursii where (Landmark = @landmark) and (LeavingHour = @leavingHour)";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@landmark", landmark);
            command.Parameters.AddWithValue("@leavingHour", leavingHour);

            int availablePlaces = -1;
            log.InfoFormat("Preparing to execute query.");
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    availablePlaces = reader.GetInt32(0);
                }

            }
            log.InfoFormat("Query finished successfuly.");
            return availablePlaces;
        }

        public List<Excursion> findAllExcursions()
        {
            log.InfoFormat("Entered findAll");
            //using (SQLiteConnection connection = JDBCUtils.getConnection())
            //{
            //    try
            //    {

            //        string query = "Select * from Excursii";
            //        SQLiteCommand command = new SQLiteCommand(query, connection);

            //        List<Excursion> excursions = new List<Excursion>();
            //        log.InfoFormat("Preparing to execute query.");
            //        using (SQLiteDataReader reader = command.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                string land = reader.GetString(1);
            //                int leavingHour = reader.GetInt32(2);
            //                int availablePlaces = reader.GetInt32(3);
            //                string transportCompany = reader.GetString(4);
            //                double price = reader.GetDouble(5);
            //                Excursion excursion = new Excursion(land, leavingHour, availablePlaces, transportCompany, price);
            //                excursions.Add(excursion);
            //            }

            //        }
            //        //connection.Close();
            //        log.InfoFormat("Query finished successfuly.");
            //        return excursions;
            //    }
            //    catch (Exception ex)
            //    {
            //        //connection.Close();
            //        log.InfoFormat("Exception thrown!");
            //        Console.WriteLine(ex.StackTrace);
            //    }
            //    return null;
            //}
            SQLiteConnection connection = JDBCUtils.getConnection();
            string query = "Select * from Excursii";
            SQLiteCommand command = new SQLiteCommand(query, connection);

            List<Excursion> excursions = new List<Excursion>();
            log.InfoFormat("Preparing to execute query.");
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string land = reader.GetString(1);
                    int leavingHour = Int32.Parse(reader.GetString(2));
                    int availablePlaces = reader.GetInt32(3);
                    string transportCompany = reader.GetString(4);
                    double price = reader.GetDouble(5);
                    Excursion excursion = new Excursion(land, leavingHour, availablePlaces, transportCompany, price);
                    excursions.Add(excursion);
                }

            }
            log.InfoFormat("Query finished successfuly.");
            return excursions;
        }

        public List<Excursion> findExcursions(string landmark, int beginTimeInterval, int endTimeInterval)
        {
            log.InfoFormat("Entered findExcursions");
            //using (SQLiteConnection connection = JDBCUtils.getConnection())
            //{
            //    try
            //    {

            //        string query = "Select * from Excursii where (Landmark = @landmark) and (LeavingHour between @start and @end)";
            //        SQLiteCommand command = new SQLiteCommand(query, connection);
            //        command.Parameters.AddWithValue("@landmark", landmark);
            //        command.Parameters.AddWithValue("@start", beginTimeInterval);
            //        command.Parameters.AddWithValue("@end", endTimeInterval);

            //        List<Excursion> excursions = new List<Excursion>();
            //        log.InfoFormat("Preparing to execute query.");
            //        using (SQLiteDataReader reader = command.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                string land = reader.GetString(1);
            //                int leavingHour = reader.GetInt32(2);
            //                int availablePlaces = reader.GetInt32(3);
            //                string transportCompany = reader.GetString(4);
            //                double price = reader.GetDouble(5);
            //                Excursion excursion = new Excursion(land, leavingHour, availablePlaces, transportCompany, price);
            //                excursions.Add(excursion);
            //            }

            //        }
            //        //connection.Close();
            //        log.InfoFormat("Query finished successfuly.");
            //        return excursions;
            //    }
            //    catch (Exception ex)
            //    {
            //        //connection.Close();
            //        log.InfoFormat("Exception thrown!");
            //        Console.WriteLine(ex.StackTrace);
            //    }
            //    return null;
            //}
            SQLiteConnection connection = JDBCUtils.getConnection();

            string query = "Select * from Excursii where (Landmark = @landmark) and (LeavingHour between @start and @end)";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@landmark", landmark);
            command.Parameters.AddWithValue("@start", beginTimeInterval);
            command.Parameters.AddWithValue("@end", endTimeInterval);

            List<Excursion> excursions = new List<Excursion>();
            log.InfoFormat("Preparing to execute query.");
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string land = reader.GetString(1);
                    int leavingHour = Int32.Parse(reader.GetString(2));
                    int availablePlaces = reader.GetInt32(3);
                    string transportCompany = reader.GetString(4);
                    double price = reader.GetDouble(5);
                    Excursion excursion = new Excursion(land, leavingHour, availablePlaces, transportCompany, price);
                    excursions.Add(excursion);
                }

            }
            log.InfoFormat("Query finished successfuly.");
            return excursions;
        }

        public int findOne(string landmark, int leavingHour)
        {
            log.InfoFormat("Entered findOne");
            //using (SQLiteConnection connection = JDBCUtils.getConnection())
            //{
            //    try
            //    {
            //        string query = "Select ID from Excursii where (Landmark = @landmark) and (LeavingHour = @leavingHour)";
            //        SQLiteCommand command = new SQLiteCommand(query, connection);
            //        command.Parameters.AddWithValue("@landmark", landmark);
            //        command.Parameters.AddWithValue("@leavingHour", leavingHour);

            //        int id = -1;
            //        log.InfoFormat("Preparing to execute query.");
            //        using (SQLiteDataReader reader = command.ExecuteReader())
            //        {
            //            if (reader.Read())
            //            {
            //                id = reader.GetInt32(0);
            //            }

            //        }
            //        //connection.Close();
            //        log.InfoFormat("Query finished successfuly.");
            //        return id;
            //    }
            //    catch (Exception ex)
            //    {
            //        //connection.Close();
            //        log.InfoFormat("Exception thrown!");
            //        Console.WriteLine(ex.StackTrace);
            //    }
            //    return -1;
            //}
            SQLiteConnection connection = JDBCUtils.getConnection();
                    string query = "Select ID from Excursii where (Landmark = @landmark) and (LeavingHour = @leavingHour)";
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    command.Parameters.AddWithValue("@landmark", landmark);
                    command.Parameters.AddWithValue("@leavingHour", leavingHour);

                    int id = -1;
                    log.InfoFormat("Preparing to execute query.");
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            id = reader.GetInt32(0);
                        }

                    }
                    //connection.Close();
                    log.InfoFormat("Query finished successfuly.");
                    return id;
        }

        public void updateTickets(int idExcursion, int nrTickets)
        {
            log.InfoFormat("Entered updateTickets");
            //using (SQLiteConnection connection = JDBCUtils.getConnection())
            //{
            //    try
            //    {

            //        string queryFind = "Select AvailablePlaces from Excursii where ID = @id";
            //        SQLiteCommand commandFind = new SQLiteCommand(queryFind, connection);
            //        commandFind.Parameters.AddWithValue("@id", idExcursion);
            //        int availableP = 0;
            //        log.InfoFormat("Preparing to execute query.");
            //        using (SQLiteDataReader reader = commandFind.ExecuteReader())
            //        {
            //            if (reader.Read())
            //            {
            //                availableP = reader.GetInt32(0);
            //            }

            //        }

            //        string query = "Update Excursii set AvailablePlaces = @availablePlaces where ID = @id";
            //        SQLiteCommand command = new SQLiteCommand(query, connection);
            //        int newPlaces = availableP - nrTickets;
            //        command.Parameters.AddWithValue("@availablePlaces", newPlaces);
            //        command.Parameters.AddWithValue("@id", idExcursion);

            //        command.ExecuteNonQuery();

            //        //connection.Close();
            //        log.InfoFormat("Query finished successfuly.");
            //    }
            //    catch (Exception ex)
            //    {
            //        //connection.Close();
            //        log.InfoFormat("Exception thrown!");
            //        Console.WriteLine(ex.StackTrace);
            //    }
            //}
            SQLiteConnection connection = JDBCUtils.getConnection();

            string queryFind = "Select AvailablePlaces from Excursii where ID = @id";
            SQLiteCommand commandFind = new SQLiteCommand(queryFind, connection);
            commandFind.Parameters.AddWithValue("@id", idExcursion);
            int availableP = 0;
            log.InfoFormat("Preparing to execute query.");
            using (SQLiteDataReader reader = commandFind.ExecuteReader())
            {
                if (reader.Read())
                {
                    availableP = reader.GetInt32(0);
                }

            }

            string query = "Update Excursii set AvailablePlaces = @availablePlaces where ID = @id";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            int newPlaces = availableP - nrTickets;
            command.Parameters.AddWithValue("@availablePlaces", newPlaces);
            command.Parameters.AddWithValue("@id", idExcursion);

            command.ExecuteNonQuery();
           
            log.InfoFormat("Query finished successfuly.");
        }

        public void add(Excursion t)
        {
            throw new NotImplementedException();
        }

        public void delete(Excursion t)
        {
            throw new NotImplementedException();
        }

        public void update(Excursion t)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Excursion> findAll()
        {
            throw new NotImplementedException();
        }
    }
}
