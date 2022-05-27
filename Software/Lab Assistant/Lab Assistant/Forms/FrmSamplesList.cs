using DBLayer;
using Lab_Assistant.Forms;
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

namespace Lab_Assistant
{
    public partial class FrmSamplesList : Form
    {

        public FrmSamplesList()
        {
            InitializeComponent();
            DB.SetConfiguration("mkaraula20_DB", "mkaraula20", "Rv0w!:eA");
        }

        private void FrmPopisUzoraka_Load(object sender, EventArgs e)
        {
            ShowSamples();
        }

        private void ShowSamples()
        {
            var samples = SampleRepository.GetSamples();
            dgvSamples.DataSource = samples;

            dgvSamples.Columns["SampleId"].DisplayIndex = 0;
            dgvSamples.Columns["Date"].DisplayIndex = 1;
            dgvSamples.Columns["Status"].DisplayIndex = 2;
            dgvSamples.Columns["Opinion"].DisplayIndex = 3;
        }

        private void btnOpenSample_Click(object sender, EventArgs e)
        {
            Sample selectedSample = dgvSamples.CurrentRow.DataBoundItem as Sample;
            if (selectedSample != null)
            {
                FrmSample frmSample = new FrmSample(selectedSample);
                frmSample.ShowDialog();
            }
         }

        private void dgvSamples_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ShowSamples();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowSamples();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtPatientSearch.Text != "")
            {
                string searchPatient = txtPatientSearch.Text;
                ShowSearchedSamples(searchPatient);
            }
        }

        private void ShowSearchedSamples(string patientName)
        {
            var searchedSamples = SampleRepository.GetSearchedSamples(SampleRepository.GetSearchedPatients(patientName));
            dgvSamples.DataSource = searchedSamples;

            dgvSamples.Columns["SampleId"].DisplayIndex = 0;
            dgvSamples.Columns["Date"].DisplayIndex = 1;
            dgvSamples.Columns["Status"].DisplayIndex = 2;
            dgvSamples.Columns["Opinion"].DisplayIndex = 3;
        }
    }
}
