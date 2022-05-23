﻿using Lab_Assistant.Forms;
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
    public partial class FrmPopisUzoraka : Form
    {
        FrmSample frmSample = new FrmSample();
        public FrmPopisUzoraka()
        {
            InitializeComponent();
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

        private void btnOpenSamples_Click(object sender, EventArgs e)
        {
            frmSample.ShowDialog();
         }

    }
}
