using System.Windows.Forms;

namespace butik.util
{
    internal static class MessageUtil
    {
        static public void ShowError(string message)
        {
            MessageBox.Show(
                message,
                "GREŠKA",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }

        static public DialogResult DeleteBox(string meessage)
        {
            return MessageBox.Show(
                meessage,
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
        }

        static public void Notification(string meessage)
        {
            MessageBox.Show(
                meessage,
                "",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
