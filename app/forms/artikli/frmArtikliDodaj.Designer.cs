namespace butik.forms.artikli
{
    partial class frmArtikliDodaj
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            // 
            // cBoxId
            // 
            this.cBoxId.FormattingEnabled = true;
            this.cBoxId.Location = new System.Drawing.Point(184, 99);
            this.cBoxId.Name = "cBoxId";
            this.cBoxId.Size = new System.Drawing.Size(184, 21);
            this.cBoxId.TabIndex = 1;
            this.cBoxId.SelectedIndexChanged += new System.EventHandler(this.cBoxId_SelectedIndexChanged);
            // 
            // tBoxNaziv
            // 
            this.tBoxNaziv.Location = new System.Drawing.Point(184, 168);
            this.tBoxNaziv.Name = "tBoxNaziv";
            this.tBoxNaziv.Size = new System.Drawing.Size(184, 20);
            this.tBoxNaziv.TabIndex = 2;
            // 
            // tBoxKolicina
            // 
            this.tBoxKolicina.Location = new System.Drawing.Point(184, 233);
            this.tBoxKolicina.Name = "tBoxKolicina";
            this.tBoxKolicina.Size = new System.Drawing.Size(184, 20);
            this.tBoxKolicina.TabIndex = 3;
            // 
            // tBoxCena
            // 
            this.tBoxCena.Location = new System.Drawing.Point(184, 285);
            this.tBoxCena.Name = "tBoxCena";
            this.tBoxCena.Size = new System.Drawing.Size(184, 20);
            this.tBoxCena.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Naziv artikla";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kolicina artikla";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cena artikla";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(494, 467);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(142, 37);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(72, 467);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(142, 37);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Izlaz";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmArtikliDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(709, 531);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBoxCena);
            this.Controls.Add(this.tBoxKolicina);
            this.Controls.Add(this.tBoxNaziv);
            this.Controls.Add(this.cBoxId);
            this.Controls.Add(this.label1);
            this.Name = "frmArtikliDodaj";
            this.Load += new System.EventHandler(this.frmArtikliDodaj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxId;
        private System.Windows.Forms.TextBox tBoxNaziv;
        private System.Windows.Forms.TextBox tBoxKolicina;
        private System.Windows.Forms.TextBox tBoxCena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
    }
}
