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


        public static void CreateSample(Sample sample)
        {
            string sql = $"INSERT INTO Sample (SampleId, Date, Status, Results, PatientIdPatient, WorkWarrantId) VALUES ({sample.SampleId}, GETDATE(), '{sample.Status}', '{sample.Results}', {sample.PatientId}, {sample.WorkWarrantId})";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void DeleteSample(Sample selectedSample)
        {
            string sql = $"DELETE FROM Sample WHERE SampleId = {selectedSample.SampleId}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
