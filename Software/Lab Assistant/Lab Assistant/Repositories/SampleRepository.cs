﻿using DBLayer;
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
                sample = CreateObject(reader);
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
                Sample sample = CreateObject(reader);
                samples.Add(sample);
            }
            reader.Close();
            DB.CloseConnection();
            return samples;
        }

        private static Sample CreateObject(SqlDataReader reader)
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

        internal static void DeleteOpinion(int id)
        {
            string sql = $"UPDATE Sample SET Opinion = null WHERE SampleId = {id}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
