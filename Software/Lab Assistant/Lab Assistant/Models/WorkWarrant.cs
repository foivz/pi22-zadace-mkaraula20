using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assistant.Models
{
    public class WorkWarrant
    {
        public int WorkWarrantId { get; set; }
        public DateTime WorkWarrantDate { get; set; }
        public string WorkWarrantAnalysis { get; set; }
        public override string ToString()
        {
            return WorkWarrantId.ToString();
        }
    }
}
