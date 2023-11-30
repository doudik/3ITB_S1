using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace SingletonDBManager
{
    internal sealed class ConnectionManager
    {
        MySqlConnection connection;
        public static ConnectionManager manager { get; } = new ConnectionManager();

        public ConnectionManager(){
        }
        public void Connect()
        {
            string connString = "server=localhost;uid=root;pwd=;database=zaci3ITB";
            connection = new MySqlConnection(connString);
            try
            {
                connection.Open();
                Console.WriteLine("Připojeno!");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Disconect() {
            try
            {
                connection.Close();
                Console.WriteLine("Odpojeno!");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Execute(string sql)
        {
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            //TODO - opravit pro vkládání / získávání
        }
        public void Vypis() {
            string sql = "SELECT * FROM zaci";
            MySqlDataReader reader = new MySqlCommand(sql, connection).ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write($"{reader.GetName(i)}: {reader.GetValue(i)} | ");
                }
                Console.WriteLine();
            }

        }
        public void PridatZaznam(string jmeno, string prijmeni) {
            string sql = $"INSERT INTO zaci(jmeno, prijmeni) VALUES ('{jmeno}', '{prijmeni}')";
            Execute(sql);
            //TODO check jmena && prijmeni
        }
        public void OdeberZaznam(string jmeno = null, string prijmeni = null){
            string sql;
            if (jmeno == null && prijmeni == null)
            {
                throw new Exception("Musíte zadat alespoň jedno jméno!");
            }
            else if (jmeno == null)
            {
                sql = $"DELETE FROM zaci WHERE prijmeni = '{prijmeni}'";
                Execute(sql);
            }
            else if (prijmeni == null)
            {
                sql = $"DELETE FROM zaci WHERE jmeno = '{jmeno}'";
                Execute(sql);
            }
            else { 
                sql = $"DELETE FROM zaci WHERE jmeno = '{jmeno}' AND prijmeni = '{prijmeni}'";
                Execute(sql);
            }
            
            
        }
    }
}
