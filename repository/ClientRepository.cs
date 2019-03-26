using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgentieDeTurismMpp.model;
using log4net;

namespace AgentieDeTurismMpp.repository
{
    class ClientRepository : IClientRepository
    {
        private static readonly ILog log = LogManager.GetLogger("ClientRepository");

        public int findOne(Client client)
        {
            log.InfoFormat("Entered findClient");
            //using (SQLiteConnection connection = JDBCUtils.getConnection())
            //{
            //    try
            //    {

            //        string query = "Select ID from Clienti where LastName = @lastName and FirstName = @firstName and TelephoneNr = @telephoneNr";
            //        SQLiteCommand command = new SQLiteCommand(query, connection);
            //        command.Parameters.AddWithValue("@lastName", client.LastName);
            //        command.Parameters.AddWithValue("@firstName", client.FirstName);
            //        command.Parameters.AddWithValue("@telephoneNr", client.TelephoneNr);

            //        int id = -1;
            //        using (SQLiteDataReader reader = command.ExecuteReader())
            //        {
            //            if (reader.Read())
            //            {
            //                id = reader.GetInt32(0);

            //            }
            //            else
            //            {
            //                string queryAdd = "Insert into Clienti(LastName, FirstName, TelephoneNr)  values (@lastName,@firstName,@telephoneNr)";
            //                SQLiteCommand commandAdd = new SQLiteCommand(queryAdd, connection);
            //                commandAdd.Parameters.AddWithValue("@lastName", client.LastName);
            //                commandAdd.Parameters.AddWithValue("@firstName", client.FirstName);
            //                commandAdd.Parameters.AddWithValue("@telephoneNr", client.TelephoneNr);
            //                commandAdd.ExecuteNonQuery();

            //                string querySearch = "Select ID from Clienti where LastName = @lastName and FirstName = @firstName and TelephoneNr = @telephoneNr";
            //                SQLiteCommand commandSearch = new SQLiteCommand(querySearch, connection);
            //                commandSearch.Parameters.AddWithValue("@lastName", client.LastName);
            //                commandSearch.Parameters.AddWithValue("@firstName", client.FirstName);
            //                commandSearch.Parameters.AddWithValue("@telephoneNr", client.TelephoneNr); 
            //                using (SQLiteDataReader reader2 = commandSearch.ExecuteReader())
            //                {
            //                    if (reader2.Read())
            //                    {
            //                        id = reader.GetInt32(0);

            //                    }
            //                }

            //            }

            //        }
            //        //connection.Close();
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
            string query = "Select ID from Clienti where LastName = @lastName and FirstName = @firstName and TelephoneNr = @telephoneNr";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@lastName", client.LastName);
            command.Parameters.AddWithValue("@firstName", client.FirstName);
            command.Parameters.AddWithValue("@telephoneNr", client.TelephoneNr);

            int id = -1;
            log.InfoFormat("Preparing to execute query.");
            using (SQLiteDataReader reader = command.ExecuteReader())
             {
                if (reader.Read())
                {
                    id = reader.GetInt32(0);

                }
                else
                {
                    string queryAdd = "Insert into Clienti(LastName, FirstName, TelephoneNr)  values (@lastName,@firstName,@telephoneNr)";
                    SQLiteCommand commandAdd = new SQLiteCommand(queryAdd, connection);
                    commandAdd.Parameters.AddWithValue("@lastName", client.LastName);
                    commandAdd.Parameters.AddWithValue("@firstName", client.FirstName);
                    commandAdd.Parameters.AddWithValue("@telephoneNr", client.TelephoneNr);
                    commandAdd.ExecuteNonQuery();

                    string querySearch = "Select ID from Clienti where LastName = @lastName and FirstName = @firstName and TelephoneNr = @telephoneNr";
                    SQLiteCommand commandSearch = new SQLiteCommand(querySearch, connection);
                    commandSearch.Parameters.AddWithValue("@lastName", client.LastName);
                    commandSearch.Parameters.AddWithValue("@firstName", client.FirstName);
                    commandSearch.Parameters.AddWithValue("@telephoneNr", client.TelephoneNr);
                    log.InfoFormat("Preparing to execute add query of new client.");
                    using (SQLiteDataReader reader2 = commandSearch.ExecuteReader())
                    {
                        if (reader2.Read())
                        {
                            id = reader.GetInt32(0);

                        }
                    }
                    log.InfoFormat("Query finished successfuly.");
                }

            }
            return id;
        }

        public void add(Client t)
        {
            throw new NotImplementedException();
        }

        public void delete(Client t)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client> findAll()
        {
            throw new NotImplementedException();
        }

        public void update(Client t)
        {
            throw new NotImplementedException();
        }
    }
}
