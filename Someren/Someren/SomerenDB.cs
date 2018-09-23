using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Someren
{
    class SomerenDB
    {  
        private SqlConnection openConnectieDB()
        {
            string host = "den1.mssql3.gear.host";
            string db = "pdb1819f3";
            string user = "pdb1819f3";
            string password = "Ab2Ls9g2X?_3";
            //string port = "3306";

            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = host;
                builder.UserID = user;
                builder.Password = password;
                builder.InitialCatalog = db;

                SqlConnection connection = new SqlConnection(builder.ConnectionString);
                
                connection.Open();
                return connection;

            }
            catch (SqlException e)
            {
                SqlConnection connection = null;
                Console.WriteLine(e.ToString());
                return connection;
            }            
        }


        private void sluitConnectieDB(SqlConnection connection)
        {
            connection.Close();
        }

        public List<SomerenModel.Student> DB_getstudents()
        {
            SqlConnection connection = openConnectieDB();
            List<SomerenModel.Student> studenten_lijst = new List<SomerenModel.Student>();

            //connection.Open();
            StringBuilder sb = new StringBuilder();
            // schrijf hier een query om te zorgen dat er een lijst met studenten wordt getoond
            sb.Append("SELECT student_id,student_voornaam,student_achternaam FROM studenten");

            String sql = sb.ToString();

            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = (int)reader["student_id"];
                string naam = (string)reader["student_voornaam"];
                string achternaam = (string)reader["student_achternaam"];

                SomerenModel.Student student = new SomerenModel.Student();

                student.setId(id);
                student.setNaam(naam);
                student.setAchterNaam(achternaam);


                studenten_lijst.Add(student);
            }
            sluitConnectieDB(connection);
            return studenten_lijst;
        }


        public List<SomerenModel.Docent> DB_getteachers()
        {
            SqlConnection connection = openConnectieDB();
            List<SomerenModel.Docent> docenten_lijst = new List<SomerenModel.Docent>();

            //connection.Open();
            StringBuilder sb = new StringBuilder();
 // SELECT Query voor docenten
            sb.Append("SELECT docent_id, docent_naam, docent_achternaam FROM docenten");


            String sql = sb.ToString();

            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = (int)reader["docent_id"];
                string naam = (string)reader["docent_naam"];
                string achternaam = (string)reader["docent_achternaam"];

                SomerenModel.Docent docent = new SomerenModel.Docent();

                docent.setId(id);
                docent.setNaam(naam);
                docent.setAchternaam(achternaam);

                docenten_lijst.Add(docent);
            }
            sluitConnectieDB(connection);
            return docenten_lijst;
        }

        public List<SomerenModel.Kamers> DB_getKamers()
        {
            SqlConnection connection = openConnectieDB();
            List<SomerenModel.Kamers> kamers_lijst = new List<SomerenModel.Kamers>();

            //connection.Open();
            StringBuilder sb = new StringBuilder();
            // schrijf hier een query om te zorgen dat er een lijst met studenten wordt getoond
            sb.Append("SELECT kamer_nummer, kamer_Bedden, kamer_DocentJN FROM kamers");

            String sql = sb.ToString();

            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int kamerNr = (int)reader["kamer_nummer"];
                int aantalBedden = (int)reader["kamer_Bedden"];
                string kamerDocent = (string)reader["kamer_DocentJN"];

                SomerenModel.Kamers kamer = new SomerenModel.Kamers();

                kamer.setKamerNummer(kamerNr);
                kamer.setKamerBedden(aantalBedden);
                kamer.setKamerDocent(kamerDocent);


                kamers_lijst.Add(kamer);
            }
            sluitConnectieDB(connection);
            return kamers_lijst;
        }
    }
}
