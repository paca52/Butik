using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace butik.util
{
    internal static class PanelHandler
    {
        public static frmMain parentForm;
        public static Stack<Form> formStack = new Stack<Form>();
        public static Boolean ShowTopForm()
        {
            if (formStack.Count == 0) return false;
            Form child = formStack.Peek();

            child.TopLevel = false;
            child.AutoScroll = true;
            parentForm.pnlScreen.Controls.Add(child);
            child.BringToFront();
            child.Show();

            return true;
        }

        /*
        public static Boolean ShowForm(Form child)
        {
            child.TopLevel = false;
            child.AutoScroll = true;
            parentForm.pnlScreen.Controls.Add(child);
            child.BringToFront();
            child.Show();

            return true;
        }
        */

        public static Boolean SetParentForm(frmMain parent)
        {
            parentForm = parent;
            return true;
        }

        public static Boolean AddForm(Form frm)
        {
            formStack.Push(frm);
            return true;
        }

        public static Boolean EmptyFormStack()
        {
            foreach(Form f in formStack)
            {
                f.Dispose();
            }
            formStack.Clear();
            return true;
        }

        public static Boolean RemoveTopForm()
        {
            Form frm = (Form)formStack.Pop();
            frm.Dispose();

            return true;
        }
    }
}
