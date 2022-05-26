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
            this.btnChangeAnalysisData = new System.Windows.Forms.Button();
            this.btnShowAnlysisHistory = new System.Windows.Forms.Button();
            this.btnWriteOpinion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtOpinion = new System.Windows.Forms.TextBox();
            this.txtPatient = new System.Windows.Forms.TextBox();
            this.txtWorkWarrant = new System.Windows.Forms.TextBox();
            this.btnDeleteOpinion = new System.Windows.Forms.Button();
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
            // btnChangeAnalysisData
            // 
            this.btnChangeAnalysisData.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnChangeAnalysisData.Location = new System.Drawing.Point(22, 633);
            this.btnChangeAnalysisData.Name = "btnChangeAnalysisData";
            this.btnChangeAnalysisData.Size = new System.Drawing.Size(143, 47);
            this.btnChangeAnalysisData.TabIndex = 4;
            this.btnChangeAnalysisData.Text = "Izmijeni podatke o analizi";
            this.btnChangeAnalysisData.UseVisualStyleBackColor = true;
            // 
            // btnShowAnlysisHistory
            // 
            this.btnShowAnlysisHistory.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnShowAnlysisHistory.Location = new System.Drawing.Point(213, 633);
            this.btnShowAnlysisHistory.Name = "btnShowAnlysisHistory";
            this.btnShowAnlysisHistory.Size = new System.Drawing.Size(143, 47);
            this.btnShowAnlysisHistory.TabIndex = 5;
            this.btnShowAnlysisHistory.Text = "Prikaži povijest analiza";
            this.btnShowAnlysisHistory.UseVisualStyleBackColor = true;
            // 
            // btnWriteOpinion
            // 
            this.btnWriteOpinion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWriteOpinion.Location = new System.Drawing.Point(595, 633);
            this.btnWriteOpinion.Name = "btnWriteOpinion";
            this.btnWriteOpinion.Size = new System.Drawing.Size(143, 47);
            this.btnWriteOpinion.TabIndex = 6;
            this.btnWriteOpinion.Text = "Upiši mišljenje";
            this.btnWriteOpinion.UseVisualStyleBackColor = true;
            this.btnWriteOpinion.Click += new System.EventHandler(this.btnWriteOpinion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Datum vađenja uzorka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Status uzorka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Rezultat analize:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mišljenje specijalista:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 523);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Pacijent:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(63, 569);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Radni nalog:";
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.SystemColors.Control;
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDate.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtDate.Location = new System.Drawing.Point(280, 90);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(143, 13);
            this.txtDate.TabIndex = 13;
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.SystemColors.Control;
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStatus.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtStatus.Location = new System.Drawing.Point(280, 139);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(143, 13);
            this.txtStatus.TabIndex = 14;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.Control;
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResult.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtResult.Location = new System.Drawing.Point(280, 188);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(411, 120);
            this.txtResult.TabIndex = 15;
            // 
            // txtOpinion
            // 
            this.txtOpinion.BackColor = System.Drawing.SystemColors.Control;
            this.txtOpinion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOpinion.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtOpinion.Location = new System.Drawing.Point(280, 393);
            this.txtOpinion.Multiline = true;
            this.txtOpinion.Name = "txtOpinion";
            this.txtOpinion.ReadOnly = true;
            this.txtOpinion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOpinion.Size = new System.Drawing.Size(411, 97);
            this.txtOpinion.TabIndex = 16;
            // 
            // txtPatient
            // 
            this.txtPatient.BackColor = System.Drawing.SystemColors.Control;
            this.txtPatient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPatient.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtPatient.Location = new System.Drawing.Point(280, 523);
            this.txtPatient.Name = "txtPatient";
            this.txtPatient.ReadOnly = true;
            this.txtPatient.Size = new System.Drawing.Size(100, 13);
            this.txtPatient.TabIndex = 17;
            // 
            // txtWorkWarrant
            // 
            this.txtWorkWarrant.BackColor = System.Drawing.SystemColors.Control;
            this.txtWorkWarrant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWorkWarrant.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtWorkWarrant.Location = new System.Drawing.Point(280, 569);
            this.txtWorkWarrant.Name = "txtWorkWarrant";
            this.txtWorkWarrant.ReadOnly = true;
            this.txtWorkWarrant.Size = new System.Drawing.Size(100, 13);
            this.txtWorkWarrant.TabIndex = 18;
            // 
            // btnDeleteOpinion
            // 
            this.btnDeleteOpinion.Location = new System.Drawing.Point(404, 633);
            this.btnDeleteOpinion.Name = "btnDeleteOpinion";
            this.btnDeleteOpinion.Size = new System.Drawing.Size(143, 47);
            this.btnDeleteOpinion.TabIndex = 19;
            this.btnDeleteOpinion.Text = "Obriši mišljenje";
            this.btnDeleteOpinion.UseVisualStyleBackColor = true;
            this.btnDeleteOpinion.Click += new System.EventHandler(this.btnDeleteOpinion_Click);
            // 
            // FrmSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 700);
            this.Controls.Add(this.btnDeleteOpinion);
            this.Controls.Add(this.txtWorkWarrant);
            this.Controls.Add(this.txtPatient);
            this.Controls.Add(this.txtOpinion);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnWriteOpinion);
            this.Controls.Add(this.btnShowAnlysisHistory);
            this.Controls.Add(this.btnChangeAnalysisData);
            this.Controls.Add(this.txtSampleId);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSample";
            this.Text = "Uzorak";
            this.Load += new System.EventHandler(this.FrmSample_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSampleId;
        private System.Windows.Forms.Button btnChangeAnalysisData;
        private System.Windows.Forms.Button btnShowAnlysisHistory;
        private System.Windows.Forms.Button btnWriteOpinion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtOpinion;
        private System.Windows.Forms.TextBox txtPatient;
        private System.Windows.Forms.TextBox txtWorkWarrant;
        private System.Windows.Forms.Button btnDeleteOpinion;
    }
}