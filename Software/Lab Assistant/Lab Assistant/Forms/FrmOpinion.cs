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
    public partial class FrmOpinion : Form
    {

        private Sample sample;

        public Sample SelectedSample { get => sample; set => sample = value; }

        public FrmSamplesList Samples { get; set; }

        public FrmOpinion(Sample selectedSample)
        {
            InitializeComponent();
            SelectedSample = selectedSample;
        }

        private void FrmOpinion_Load(object sender, EventArgs e)
        {
            var sample = SampleRepository.GetSample(SelectedSample.SampleId);
            if(sample.Opinion != null)
            {
                txtOpinion.Text = sample.Opinion.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string opinion = txtOpinion.Text;
            sample.WriteOpinion(SelectedSample, opinion);
            
            FrmSample frmSample = new FrmSample(SelectedSample);
            frmSample.ShowDialog();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmSample frmSample = new FrmSample(SelectedSample);
            frmSample.ShowDialog();
            Close();
        }
    }
}
