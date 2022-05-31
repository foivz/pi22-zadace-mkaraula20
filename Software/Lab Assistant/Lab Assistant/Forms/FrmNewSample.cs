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
    public partial class FrmNewSample : Form
    {
        List<Sample> AllSamples { get; set; }
        Sample NewSample { get; set; }
        public FrmNewSample()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
            FrmSamplesList frmSamplesList = new FrmSamplesList();
            frmSamplesList.ShowDialog();
        }

        private void FrmNewSample_Load(object sender, EventArgs e)
        {
            List<Patient> patients = PatientRepository.GetPatients();
            List<WorkWarrant> workWarrants = WorkWarrantRepository.GetUnusedWorkWarrants();
            AllSamples = SampleRepository.GetSamples();
            NewSample = new Sample();
            NewSample.SampleId = AllSamples.Last().SampleId + 1;
            txtDate.Text = DateTime.Now.ToString();
            cboPatient.DataSource = patients;
            cboWorkWarrant.DataSource = workWarrants;
        }

        private void btnCreateSample_Click(object sender, EventArgs e)
        {
            NewSample.WorkWarrantId = int.Parse(cboWorkWarrant.Text);
            NewSample.PatientId = cboPatient.SelectedIndex;
            NewSample.Results = txtResult.Text;
            NewSample.Status = txtStatus.Text;
            SampleRepository.CreateSample(NewSample);
            Hide();
            Close();
            FrmSamplesList frmSamplesList = new FrmSamplesList();
            frmSamplesList.ShowDialog();
        }


    }
}
