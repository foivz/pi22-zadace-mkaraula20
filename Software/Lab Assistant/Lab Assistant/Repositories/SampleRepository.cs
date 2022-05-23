using Lab_Assistant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assistant.Repositories
{
    public class SampleRepository
    {
        public static Sample GetSample(int id)
        {
            string sql = $"SELECT * FROM Sample WHERE Id = {id}";
            DB.OpenConnection();
        }
    }
}
