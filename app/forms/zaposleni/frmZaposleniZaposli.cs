using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Linq;


namespace butik.forms.zaposleni
{
    public partial class frmZaposleniZaposli : butik.forms.frmEmbeddedTemplate
    {
        public frmZaposleniZaposli()
        {
            InitializeComponent();
            HandleInputRealTime(tbJmbg);

        }

        private void HandleInputRealTime(System.Windows.Forms.TextBox tbJmbg)
        {
            tbJmbg.TextChanged += (sender, e) =>
            {
                int selectionStart = tbJmbg.SelectionStart; // Save the cursor position

                // if user entered the digit
                if (tbJmbg.Text.Any(c => char.IsDigit(c)))
                {
                    // Non-digit character detected, remove the last entered character
                    // Optionally, provide feedback to the user
                    lblWarningCifre.Visible = false;
                }

                // Check if the entered text contains any non-digit characters
                if (tbJmbg.Text.Any(c => !char.IsDigit(c)))
                {
                    // Non-digit character detected, remove the last entered character
                    tbJmbg.Text = tbJmbg.Text.Substring(0, tbJmbg.Text.Length - 1);
                    // Optionally, provide feedback to the user
                    lblWarningCifre.Text = "Dozvoljeni karakteri su samo cifre.";
                    lblWarningCifre.Visible = true;
                }

                // Limit the length of the text to 13 characters
                if (tbJmbg.Text.Length >= 13)
                {
                    // If the length exceeds 13 characters, truncate the text to 13 characters
                    tbJmbg.Text = tbJmbg.Text.Substring(0, 13);
                    lblWarningCifre.Visible = false;
                }

                // Restore the cursor position
                tbJmbg.SelectionStart = selectionStart;
            };
        }

    }
}
