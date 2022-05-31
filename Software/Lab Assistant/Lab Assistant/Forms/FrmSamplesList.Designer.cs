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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtPatientSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCreateNewSample = new System.Windows.Forms.Button();
            this.btnDeleteSample = new System.Windows.Forms.Button();
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
            this.dgvSamples.Location = new System.Drawing.Point(23, 85);
            this.dgvSamples.Name = "dgvSamples";
            this.dgvSamples.ReadOnly = true;
            this.dgvSamples.Size = new System.Drawing.Size(956, 394);
            this.dgvSamples.TabIndex = 1;
            this.dgvSamples.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSamples_CellValueChanged);
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
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(757, 485);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(108, 47);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Osvježi";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtPatientSearch
            // 
            this.txtPatientSearch.Location = new System.Drawing.Point(615, 59);
            this.txtPatientSearch.Name = "txtPatientSearch";
            this.txtPatientSearch.Size = new System.Drawing.Size(142, 20);
            this.txtPatientSearch.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(763, 59);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Pretraži";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(612, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pretraži po imenu pacijenta:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(878, 59);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Poništi";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCreateNewSample
            // 
            this.btnCreateNewSample.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCreateNewSample.Location = new System.Drawing.Point(23, 486);
            this.btnCreateNewSample.Name = "btnCreateNewSample";
            this.btnCreateNewSample.Size = new System.Drawing.Size(108, 47);
            this.btnCreateNewSample.TabIndex = 9;
            this.btnCreateNewSample.Text = "Kreiraj novi uzorak";
            this.btnCreateNewSample.UseVisualStyleBackColor = false;
            this.btnCreateNewSample.Click += new System.EventHandler(this.btnCreateNewSample_Click);
            // 
            // btnDeleteSample
            // 
            this.btnDeleteSample.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeleteSample.Location = new System.Drawing.Point(144, 486);
            this.btnDeleteSample.Name = "btnDeleteSample";
            this.btnDeleteSample.Size = new System.Drawing.Size(108, 47);
            this.btnDeleteSample.TabIndex = 10;
            this.btnDeleteSample.Text = "Izbriši uzorak";
            this.btnDeleteSample.UseVisualStyleBackColor = false;
            this.btnDeleteSample.Click += new System.EventHandler(this.btnDeleteSample_Click);
            // 
            // FrmSamplesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 563);
            this.Controls.Add(this.btnDeleteSample);
            this.Controls.Add(this.btnCreateNewSample);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtPatientSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnOpenSample);
            this.Controls.Add(this.dgvSamples);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSamplesList";
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
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtPatientSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCreateNewSample;
        private System.Windows.Forms.Button btnDeleteSample;
    }
}

