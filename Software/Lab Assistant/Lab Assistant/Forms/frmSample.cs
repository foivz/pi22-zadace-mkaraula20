using Lab_Assistant.Models;
using Lab_Assistant.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Assistant.Forms
{
    public partial class FrmSample : Form
    {
        private Sample sample;
        public Sample SelectedSample { get => sample; set => sample = value; }
        public FrmSample(Sample selectedSample)
        {
            InitializeComponent();
            SelectedSample = selectedSample;
        }

        private void FrmSample_Load(object sender, EventArgs e)
        {
            var sample = SampleRepository.GetSample(SelectedSample.SampleId);
            txtSampleId.Text = sample.SampleId.ToString();
            txtDate.Text = sample.Date;
            txtStatus.Text = sample.Status;
            txtOpinion.Text = sample.Opinion;
            txtPatient.Text = PatientRepository.GetPatient(SelectedSample.PatientId).Name + " " + PatientRepository.GetPatient(SelectedSample.PatientId).Surname;
            txtWorkWarrant.Text = sample.WorkWarrantId.ToString();
            txtResult.Text = sample.Results;
        }
    }
}
