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
            this.btnDostava = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwArtikli)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwArtikli
            // 
            this.dgwArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwArtikli.Location = new System.Drawing.Point(90, 67);
            this.dgwArtikli.Name = "dgwArtikli";
            this.dgwArtikli.Size = new System.Drawing.Size(531, 290);
            this.dgwArtikli.TabIndex = 0;
            // 
            // btnDostava
            // 
            this.btnDostava.Location = new System.Drawing.Point(484, 421);
            this.btnDostava.Name = "btnDostava";
            this.btnDostava.Size = new System.Drawing.Size(137, 61);
            this.btnDostava.TabIndex = 1;
            this.btnDostava.Text = "Dostava";
            this.btnDostava.UseVisualStyleBackColor = true;
            this.btnDostava.Click += new System.EventHandler(this.btnDostava_Click);
            // 
            // frmArtikliIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(709, 531);
            this.Controls.Add(this.btnDostava);
            this.Controls.Add(this.dgwArtikli);
            this.Name = "frmArtikliIndex";
            this.Load += new System.EventHandler(this.frmArtikliIndex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwArtikli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwArtikli;
        private System.Windows.Forms.Button btnDostava;
    }
}
