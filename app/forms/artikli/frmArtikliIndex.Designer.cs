namespace butik.forms.artikli
{
    partial class frmArtikliIndex
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
            this.dgwArtikli = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDostava = new System.Windows.Forms.Button();
            this.lblTile = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwArtikli)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwArtikli
            // 
            this.dgwArtikli.AllowUserToAddRows = false;
            this.dgwArtikli.AllowUserToDeleteRows = false;
            this.dgwArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwArtikli.Location = new System.Drawing.Point(48, 117);
            this.dgwArtikli.Name = "dgwArtikli";
            this.dgwArtikli.ReadOnly = true;
            this.dgwArtikli.Size = new System.Drawing.Size(605, 278);
            this.dgwArtikli.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(48, 441);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 44);
            this.panel1.TabIndex = 15;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(-22, -9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(189, 62);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Nazad";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnDostava);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Location = new System.Drawing.Point(504, 441);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(149, 44);
            this.panel3.TabIndex = 16;
            // 
            // btnDostava
            // 
            this.btnDostava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnDostava.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.btnDostava.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.btnDostava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDostava.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDostava.Location = new System.Drawing.Point(-18, -9);
            this.btnDostava.Name = "btnDostava";
            this.btnDostava.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDostava.Size = new System.Drawing.Size(177, 62);
            this.btnDostava.TabIndex = 3;
            this.btnDostava.Text = "Nova Dostava";
            this.btnDostava.UseVisualStyleBackColor = false;
            this.btnDostava.Click += new System.EventHandler(this.btnDostava_Click);
            // 
            // lblTile
            // 
            this.lblTile.AutoSize = true;
            this.lblTile.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTile.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTile.Location = new System.Drawing.Point(41, 35);
            this.lblTile.Name = "lblTile";
            this.lblTile.Size = new System.Drawing.Size(119, 37);
            this.lblTile.TabIndex = 17;
            this.lblTile.Text = "ARTIKLI";
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTable.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTable.Location = new System.Drawing.Point(49, 93);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(57, 21);
            this.lblTable.TabIndex = 18;
            this.lblTable.Text = "Artikli";
            // 
            // frmArtikliIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(709, 531);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.lblTile);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgwArtikli);
            this.Name = "frmArtikliIndex";
            this.Load += new System.EventHandler(this.frmArtikliIndex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwArtikli)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwArtikli;
        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Button btnExit;
        protected System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.Button btnDostava;
        private System.Windows.Forms.Label lblTile;
        private System.Windows.Forms.Label lblTable;
    }
}
