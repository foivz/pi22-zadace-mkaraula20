namespace Lab_Assistant.Forms
{
    partial class FrmSample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSample));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSampleId = new System.Windows.Forms.TextBox();
            this.dgvSampleDetails = new System.Windows.Forms.DataGridView();
            this.btnWriteAnalysisResults = new System.Windows.Forms.Button();
            this.btnChangeAnalysisData = new System.Windows.Forms.Button();
            this.btnShowAnlysisHistory = new System.Windows.Forms.Button();
            this.btnWriteOpinion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSampleDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uzorak br.";
            // 
            // txtSampleId
            // 
            this.txtSampleId.BackColor = System.Drawing.SystemColors.Control;
            this.txtSampleId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSampleId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSampleId.Location = new System.Drawing.Point(386, 16);
            this.txtSampleId.Name = "txtSampleId";
            this.txtSampleId.ReadOnly = true;
            this.txtSampleId.Size = new System.Drawing.Size(120, 24);
            this.txtSampleId.TabIndex = 1;
            // 
            // dgvSampleDetails
            // 
            this.dgvSampleDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSampleDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSampleDetails.Location = new System.Drawing.Point(12, 61);
            this.dgvSampleDetails.Name = "dgvSampleDetails";
            this.dgvSampleDetails.Size = new System.Drawing.Size(947, 381);
            this.dgvSampleDetails.TabIndex = 2;
            // 
            // btnWriteAnalysisResults
            // 
            this.btnWriteAnalysisResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnWriteAnalysisResults.Location = new System.Drawing.Point(12, 465);
            this.btnWriteAnalysisResults.Name = "btnWriteAnalysisResults";
            this.btnWriteAnalysisResults.Size = new System.Drawing.Size(143, 47);
            this.btnWriteAnalysisResults.TabIndex = 3;
            this.btnWriteAnalysisResults.Text = "Upiši rezultat analize";
            this.btnWriteAnalysisResults.UseVisualStyleBackColor = true;
            // 
            // btnChangeAnalysisData
            // 
            this.btnChangeAnalysisData.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnChangeAnalysisData.Location = new System.Drawing.Point(280, 465);
            this.btnChangeAnalysisData.Name = "btnChangeAnalysisData";
            this.btnChangeAnalysisData.Size = new System.Drawing.Size(143, 47);
            this.btnChangeAnalysisData.TabIndex = 4;
            this.btnChangeAnalysisData.Text = "Izmijeni podatke o analizi";
            this.btnChangeAnalysisData.UseVisualStyleBackColor = true;
            // 
            // btnShowAnlysisHistory
            // 
            this.btnShowAnlysisHistory.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnShowAnlysisHistory.Location = new System.Drawing.Point(548, 465);
            this.btnShowAnlysisHistory.Name = "btnShowAnlysisHistory";
            this.btnShowAnlysisHistory.Size = new System.Drawing.Size(143, 47);
            this.btnShowAnlysisHistory.TabIndex = 5;
            this.btnShowAnlysisHistory.Text = "Prikaži povijest analiza";
            this.btnShowAnlysisHistory.UseVisualStyleBackColor = true;
            // 
            // btnWriteOpinion
            // 
            this.btnWriteOpinion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWriteOpinion.Location = new System.Drawing.Point(816, 465);
            this.btnWriteOpinion.Name = "btnWriteOpinion";
            this.btnWriteOpinion.Size = new System.Drawing.Size(143, 47);
            this.btnWriteOpinion.TabIndex = 6;
            this.btnWriteOpinion.Text = "Upiši mišljenje";
            this.btnWriteOpinion.UseVisualStyleBackColor = true;
            // 
            // FrmSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 532);
            this.Controls.Add(this.btnWriteOpinion);
            this.Controls.Add(this.btnShowAnlysisHistory);
            this.Controls.Add(this.btnChangeAnalysisData);
            this.Controls.Add(this.btnWriteAnalysisResults);
            this.Controls.Add(this.dgvSampleDetails);
            this.Controls.Add(this.txtSampleId);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSample";
            this.Text = "Uzorak";
            this.Load += new System.EventHandler(this.FrmSample_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSampleDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSampleId;
        private System.Windows.Forms.DataGridView dgvSampleDetails;
        private System.Windows.Forms.Button btnWriteAnalysisResults;
        private System.Windows.Forms.Button btnChangeAnalysisData;
        private System.Windows.Forms.Button btnShowAnlysisHistory;
        private System.Windows.Forms.Button btnWriteOpinion;
    }
}