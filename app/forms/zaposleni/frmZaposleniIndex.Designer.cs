﻿namespace butik.forms.zaposleni
{
    partial class frmZaposleniIndex
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnOtpusti = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnZaposli = new System.Windows.Forms.Button();
            this.dgvZaposleni = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposleni)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnOtpusti);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Location = new System.Drawing.Point(213, 453);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(149, 44);
            this.panel3.TabIndex = 5;
            // 
            // btnOtpusti
            // 
            this.btnOtpusti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnOtpusti.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.btnOtpusti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.btnOtpusti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtpusti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOtpusti.Location = new System.Drawing.Point(-3, -9);
            this.btnOtpusti.Name = "btnOtpusti";
            this.btnOtpusti.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOtpusti.Size = new System.Drawing.Size(153, 62);
            this.btnOtpusti.TabIndex = 3;
            this.btnOtpusti.Text = "Otpusti";
            this.btnOtpusti.UseVisualStyleBackColor = false;
            this.btnOtpusti.Click += new System.EventHandler(this.btnOtpusti_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnZaposli);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(557, 453);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 44);
            this.panel2.TabIndex = 5;
            // 
            // btnZaposli
            // 
            this.btnZaposli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnZaposli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.btnZaposli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.btnZaposli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZaposli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZaposli.Location = new System.Drawing.Point(-3, -9);
            this.btnZaposli.Name = "btnZaposli";
            this.btnZaposli.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnZaposli.Size = new System.Drawing.Size(153, 62);
            this.btnZaposli.TabIndex = 3;
            this.btnZaposli.Text = "Zaposli";
            this.btnZaposli.UseVisualStyleBackColor = false;
            this.btnZaposli.Click += new System.EventHandler(this.btnZaposli_Click);
            // 
            // dgvZaposleni
            // 
            this.dgvZaposleni.AllowUserToAddRows = false;
            this.dgvZaposleni.AllowUserToDeleteRows = false;
            this.dgvZaposleni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvZaposleni.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvZaposleni.Location = new System.Drawing.Point(41, 25);
            this.dgvZaposleni.Name = "dgvZaposleni";
            this.dgvZaposleni.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvZaposleni.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvZaposleni.RowHeadersWidth = 100;
            this.dgvZaposleni.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvZaposleni.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvZaposleni.Size = new System.Drawing.Size(666, 396);
            this.dgvZaposleni.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.button5);
            this.panel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel5.Location = new System.Drawing.Point(41, 453);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(149, 44);
            this.panel5.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(-3, -9);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(153, 62);
            this.button5.TabIndex = 3;
            this.button5.Text = "Nazad";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnAzuriraj);
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel4.Location = new System.Drawing.Point(385, 453);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(149, 44);
            this.panel4.TabIndex = 6;
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnAzuriraj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.btnAzuriraj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.btnAzuriraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAzuriraj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAzuriraj.Location = new System.Drawing.Point(-3, -9);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAzuriraj.Size = new System.Drawing.Size(153, 62);
            this.btnAzuriraj.TabIndex = 3;
            this.btnAzuriraj.Text = "Ažuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = false;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // frmZaposleniIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(747, 521);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.dgvZaposleni);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "frmZaposleniIndex";
            this.Load += new System.EventHandler(this.frmZaposleniIndex_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposleni)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.Button btnOtpusti;
        protected System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Button btnZaposli;
        private System.Windows.Forms.DataGridView dgvZaposleni;
        protected System.Windows.Forms.Panel panel5;
        protected System.Windows.Forms.Button button5;
        protected System.Windows.Forms.Panel panel4;
        protected System.Windows.Forms.Button btnAzuriraj;
    }
}
