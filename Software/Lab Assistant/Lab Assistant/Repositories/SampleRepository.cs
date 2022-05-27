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
    public class SampleRepository
    {
        public static Sample GetSample(int id)
        {
            Sample sample = null;
            string sql = $"SELECT * FROM Sample WHERE SampleId = {id}";
            DB.SetConfiguration("mkaraula20_DB", "mkaraula20", "Rv0w!:eA");
            DB.OpenConnection();

            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                sample = CreateSampleObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return sample;
        }

        public static List<Sample> GetSamples()
        {
            List<Sample> samples = new List<Sample>();
            string sql = $"SELECT * FROM Sample";
            DB.SetConfiguration("mkaraula20_DB", "mkaraula20", "Rv0w!:eA");
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Sample sample = CreateSampleObject(reader);
                samples.Add(sample);
            }
            reader.Close();
            DB.CloseConnection();
            return samples;
        }

        private static Sample CreateSampleObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["SampleId"].ToString());
            string date = reader["Date"].ToString();
            string status = reader["Status"].ToString();
            string results = reader["Results"].ToString();
            string opinion = reader["Opinion"].ToString();
            int patientId = int.Parse(reader["PatientIdPatient"].ToString());
            int workWarrantId = int.Parse(reader["WorkWarrantId"].ToString());

            var sample = new Sample
            {
                SampleId = id,
                Date = date,
                Status = status,
                Results = results,
                Opinion = opinion,
                PatientId = patientId,
                WorkWarrantId = workWarrantId
            };
            return sample;
        }

        public static List<Patient> GetSearchedPatients(string patientName)
        {
            string sql = $"SELECT * FROM Patient WHERE Name = '{patientName}' OR Surname = '{patientName}'";
            List<Patient> searchedPatients = new List<Patient>();
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Patient patient = CreatePatientObject(reader);
                searchedPatients.Add(patient);
            }
            reader.Close();
            DB.CloseConnection();
            return searchedPatients;
        }


        private static Patient CreatePatientObject(SqlDataReader reader)
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

        public static List<Sample> GetSearchedSamples(List<Patient> patients)
        {
            List<Sample> searchedSamples = new List<Sample>();
            DB.OpenConnection();
            foreach (Patient patient in patients)
            {
                string sql = $"SELECT * FROM Sample WHERE PatientIdPatient = {patient.Id}";
                var reader = DB.GetDataReader(sql);
                while (reader.Read())
                {
                    Sample sample = CreateSampleObject(reader);
                    searchedSamples.Add(sample);
                }
                reader.Close();
            }
            DB.CloseConnection();
            return searchedSamples;
        }

        internal static void DeleteOpinion(int id)
        {
            string sql = $"UPDATE Sample SET Opinion = null WHERE SampleId = {id}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
