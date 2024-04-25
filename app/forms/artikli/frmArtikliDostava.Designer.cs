namespace butik.forms.artikli
{
    partial class frmArtikliDostava
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwItems = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwItems)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(40, 448);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 34);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Nazad";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(534, 448);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(122, 34);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Dostavi";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(534, 75);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 29);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Dodaj Artikl";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(37, 91);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(87, 13);
            this.lblTable.TabIndex = 4;
            this.lblTable.Text = "Dostavljeni Artikli";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "DOSTAVA";
            // 
            // dgwItems
            // 
            this.dgwItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwItems.Location = new System.Drawing.Point(72, 142);
            this.dgwItems.Name = "dgwItems";
            this.dgwItems.Size = new System.Drawing.Size(543, 237);
            this.dgwItems.TabIndex = 6;
            // 
            // frmArtikliDostava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(709, 531);
            this.Controls.Add(this.dgwItems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnExit);
            this.Name = "frmArtikliDostava";
            ((System.ComponentModel.ISupportInitialize)(this.dgwItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwItems;
    }
}
