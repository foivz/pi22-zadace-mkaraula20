using Lab_Assistant.Repositories;
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
        public string Date { get; set; }
        public string Status { get; set; }
        public string Results { get; set; }
        public string Opinion { get; set; }
        public int PatientId { get; set; }
        public int WorkWarrantId { get; set; }

        public void WriteOpinion(Sample selectedSample, string opinion)
        {

            OpinionRepository.SetOpinion(selectedSample, opinion);
        }
    }
}
