﻿namespace butik.forms.artikli
{
    partial class frmDostavaArtikliTemplate
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
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxId = new System.Windows.Forms.ComboBox();
            this.tBoxNaziv = new System.Windows.Forms.TextBox();
            this.tBoxKolicina = new System.Windows.Forms.TextBox();
            this.tBoxCena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tBoxDostavljenaKolicina = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCenaGreska = new System.Windows.Forms.Label();
            this.lblDostavljenaKolicinaGreska = new System.Windows.Forms.Label();
            this.lblNazivGreska = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(98, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // cBoxId
            // 
            this.cBoxId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cBoxId.FormattingEnabled = true;
            this.cBoxId.Location = new System.Drawing.Point(101, 123);
            this.cBoxId.Name = "cBoxId";
            this.cBoxId.Size = new System.Drawing.Size(532, 29);
            this.cBoxId.TabIndex = 0;
            this.cBoxId.SelectedIndexChanged += new System.EventHandler(this.cBoxId_SelectedIndexChanged);
            // 
            // tBoxNaziv
            // 
            this.tBoxNaziv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tBoxNaziv.Location = new System.Drawing.Point(101, 192);
            this.tBoxNaziv.Name = "tBoxNaziv";
            this.tBoxNaziv.Size = new System.Drawing.Size(532, 29);
            this.tBoxNaziv.TabIndex = 1;
            // 
            // tBoxKolicina
            // 
            this.tBoxKolicina.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tBoxKolicina.Location = new System.Drawing.Point(102, 266);
            this.tBoxKolicina.Name = "tBoxKolicina";
            this.tBoxKolicina.ReadOnly = true;
            this.tBoxKolicina.Size = new System.Drawing.Size(258, 29);
            this.tBoxKolicina.TabIndex = 3;
            this.tBoxKolicina.Text = "0";
            // 
            // tBoxCena
            // 
            this.tBoxCena.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tBoxCena.Location = new System.Drawing.Point(101, 332);
            this.tBoxCena.Name = "tBoxCena";
            this.tBoxCena.Size = new System.Drawing.Size(532, 29);
            this.tBoxCena.TabIndex = 3;
            this.tBoxCena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxCena_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(98, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Naziv artikla";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(98, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dostupna Kolicina Artikla";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(98, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cena artikla";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(371, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Dostavljena Kolicina Artikla";
            // 
            // tBoxDostavljenaKolicina
            // 
            this.tBoxDostavljenaKolicina.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tBoxDostavljenaKolicina.Location = new System.Drawing.Point(375, 266);
            this.tBoxDostavljenaKolicina.Name = "tBoxDostavljenaKolicina";
            this.tBoxDostavljenaKolicina.Size = new System.Drawing.Size(258, 29);
            this.tBoxDostavljenaKolicina.TabIndex = 2;
            this.tBoxDostavljenaKolicina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxDostavljenaKolicina_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Location = new System.Drawing.Point(485, 445);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(149, 44);
            this.panel3.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(-3, -9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(153, 62);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(103, 445);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 44);
            this.panel1.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(-24, -9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(189, 62);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Izlaz";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(94, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 37);
            this.label6.TabIndex = 13;
            this.label6.Text = "ARTIKL";
            // 
            // lblCenaGreska
            // 
            this.lblCenaGreska.AutoSize = true;
            this.lblCenaGreska.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCenaGreska.ForeColor = System.Drawing.Color.IndianRed;
            this.lblCenaGreska.Location = new System.Drawing.Point(100, 364);
            this.lblCenaGreska.MaximumSize = new System.Drawing.Size(258, 0);
            this.lblCenaGreska.Name = "lblCenaGreska";
            this.lblCenaGreska.Size = new System.Drawing.Size(30, 13);
            this.lblCenaGreska.TabIndex = 14;
            this.lblCenaGreska.Text = "here";
            // 
            // lblDostavljenaKolicinaGreska
            // 
            this.lblDostavljenaKolicinaGreska.AutoSize = true;
            this.lblDostavljenaKolicinaGreska.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDostavljenaKolicinaGreska.ForeColor = System.Drawing.Color.IndianRed;
            this.lblDostavljenaKolicinaGreska.Location = new System.Drawing.Point(372, 298);
            this.lblDostavljenaKolicinaGreska.MaximumSize = new System.Drawing.Size(258, 0);
            this.lblDostavljenaKolicinaGreska.Name = "lblDostavljenaKolicinaGreska";
            this.lblDostavljenaKolicinaGreska.Size = new System.Drawing.Size(30, 13);
            this.lblDostavljenaKolicinaGreska.TabIndex = 15;
            this.lblDostavljenaKolicinaGreska.Text = "here";
            // 
            // lblNazivGreska
            // 
            this.lblNazivGreska.AutoSize = true;
            this.lblNazivGreska.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivGreska.ForeColor = System.Drawing.Color.IndianRed;
            this.lblNazivGreska.Location = new System.Drawing.Point(100, 224);
            this.lblNazivGreska.MaximumSize = new System.Drawing.Size(258, 0);
            this.lblNazivGreska.Name = "lblNazivGreska";
            this.lblNazivGreska.Size = new System.Drawing.Size(30, 13);
            this.lblNazivGreska.TabIndex = 16;
            this.lblNazivGreska.Text = "here";
            // 
            // frmDostavaArtikliTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(747, 521);
            this.Controls.Add(this.lblNazivGreska);
            this.Controls.Add(this.lblDostavljenaKolicinaGreska);
            this.Controls.Add(this.lblCenaGreska);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tBoxDostavljenaKolicina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBoxCena);
            this.Controls.Add(this.tBoxKolicina);
            this.Controls.Add(this.tBoxNaziv);
            this.Controls.Add(this.cBoxId);
            this.Controls.Add(this.label1);
            this.Name = "frmDostavaArtikliTemplate";
            this.Load += new System.EventHandler(this.frmDostavaArtikliTemplate_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.ComboBox cBoxId;
        protected System.Windows.Forms.TextBox tBoxNaziv;
        protected System.Windows.Forms.TextBox tBoxKolicina;
        protected System.Windows.Forms.TextBox tBoxCena;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.TextBox tBoxDostavljenaKolicina;
        protected System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.Button btnAdd;
        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Button btnExit;
        protected System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCenaGreska;
        private System.Windows.Forms.Label lblDostavljenaKolicinaGreska;
        private System.Windows.Forms.Label lblNazivGreska;
    }
}
