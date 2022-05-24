namespace Lab_Assistant
{
    partial class FrmSamplesList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSamplesList));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSamples = new System.Windows.Forms.DataGridView();
            this.btnOpenSample = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSamples)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Popis uzoraka";
            // 
            // dgvSamples
            // 
            this.dgvSamples.AllowUserToDeleteRows = false;
            this.dgvSamples.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSamples.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSamples.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSamples.Location = new System.Drawing.Point(23, 52);
            this.dgvSamples.Name = "dgvSamples";
            this.dgvSamples.ReadOnly = true;
            this.dgvSamples.Size = new System.Drawing.Size(956, 394);
            this.dgvSamples.TabIndex = 1;
            // 
            // btnOpenSample
            // 
            this.btnOpenSample.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenSample.Location = new System.Drawing.Point(871, 485);
            this.btnOpenSample.Name = "btnOpenSample";
            this.btnOpenSample.Size = new System.Drawing.Size(108, 47);
            this.btnOpenSample.TabIndex = 3;
            this.btnOpenSample.Text = "Otvori uzorak";
            this.btnOpenSample.UseVisualStyleBackColor = true;
            this.btnOpenSample.Click += new System.EventHandler(this.btnOpenSample_Click);
            // 
            // FrmPopisUzoraka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 563);
            this.Controls.Add(this.btnOpenSample);
            this.Controls.Add(this.dgvSamples);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPopisUzoraka";
            this.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Text = "Popis uzoraka";
            this.Load += new System.EventHandler(this.FrmPopisUzoraka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSamples)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSamples;
        private System.Windows.Forms.Button btnOpenSample;
    }
}

