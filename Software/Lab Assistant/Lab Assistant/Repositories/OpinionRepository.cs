using DBLayer;
using Lab_Assistant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assistant.Repositories
{
    public class OpinionRepository
    {
        public static void SetOpinion(Sample selectedSample, string opinion)
        {
            string sql = $"UPDATE Sample SET Opinion = '{opinion}' WHERE SampleId = {selectedSample.SampleId}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
