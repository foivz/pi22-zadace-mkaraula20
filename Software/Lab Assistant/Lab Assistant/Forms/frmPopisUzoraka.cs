using Lab_Assistant.Forms;
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
            
        }

        private void btnOpenSamples_Click(object sender, EventArgs e)
        {
            frmSample.ShowDialog();
         }

    }
}
