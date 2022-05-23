using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assistant.Models
{
    public class Sample
    {
        public int SampleId { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public string Results { get; set; }
        public bool OpinionWritten { get; set; }
        Patient Patient { get; set; }
    }
}
