using DBLayer;
using Lab_Assistant.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assistant.Repositories
{
    public class PatientRepository
    {
        public static Patient GetPatient(int id)
        {
            Patient patient = null;

            string sql = $"SELECT * FROM Patient WHERE PatientId = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                patient = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return patient;
        }

        public static List<Patient> GetPatients()
        {
            List<Patient> patients = new List<Patient>();
            string sql = $"SELECT * FROM Patient";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Patient patient = CreateObject(reader);
                patients.Add(patient);
            }
            reader.Close();
            DB.CloseConnection();
            return patients;
        }


        public static List<Patient> GetSearchedPatients(string patientName)
        {
            string sql = $"SELECT * FROM Patient WHERE Name LIKE '%{patientName}%' OR Surname LIKE '%{patientName}%'";
            List<Patient> searchedPatients = new List<Patient>();
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Patient patient = CreateObject(reader);
                searchedPatients.Add(patient);
            }
            reader.Close();
            DB.CloseConnection();
            return searchedPatients;
        }

        private static Patient CreateObject(SqlDataReader reader)
        {

            int id = int.Parse(reader["PatientId"].ToString());
            string name = reader["Name"].ToString();
            string surname = reader["Surname"].ToString();

            var patient = new Patient
            {
                Id = id,
                Name = name,
                Surname = surname
            };
            return patient;
        }
    }
}
