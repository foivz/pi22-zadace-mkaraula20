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
    public class WorkWarrantRepository
    {
        public static List<WorkWarrant> GetWorkWarrants()
        {
            var workWarrants = new List<WorkWarrant>();

            string sql = $"SELECT * FROM WorkWarrant";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                WorkWarrant workWarrant = CreateObject(reader);
                workWarrants.Add(workWarrant);
            }
            reader.Close();
            DB.CloseConnection();
            return workWarrants;
        }

        public static List<WorkWarrant> GetUnusedWorkWarrants()
        {
            List<WorkWarrant> workWarrants = GetWorkWarrants();
            List<WorkWarrant> usedWorkWarrants = new List<WorkWarrant>();
            List<Sample> samples = SampleRepository.GetSamples();
            foreach(var sample in samples)
            {
                foreach(var workWarrant in workWarrants)
                {
                    if(sample.WorkWarrantId == workWarrant.WorkWarrantId)
                    {
                        usedWorkWarrants.Add(workWarrant);
                    }
                }
            }

            workWarrants = workWarrants.Except(usedWorkWarrants).ToList();

            return workWarrants;
        }

        private static WorkWarrant CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["WorkWarrantId"].ToString());
            DateTime date = DateTime.Parse(reader["Date"].ToString());
            string analysis = reader["Analysis"].ToString();

            var workWarrant = new WorkWarrant
            {
                WorkWarrantId = id,
                WorkWarrantDate = date,
                WorkWarrantAnalysis = analysis
            };

            return workWarrant;
        }
    }
}
