using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonLib
{
    internal partial class CustomMessageForm : Form
    {
        public CustomMessageForm()
        {
            InitializeComponent();
        }

        public CustomMessageForm(string message)
        {
            InitializeComponent();
            messageLabel.Text = message;
            AutoAdjustFormSize(messageLabel);
        }

        public CustomMessageForm(string message, string title)
        {
            InitializeComponent();
            messageLabel.Text = message;
            titleLabel.Text = title;
            AutoAdjustFormSize(messageLabel);
        }

        public CustomMessageForm(string message, string title, MessageBoxButtons buttons)
        {
            InitializeComponent();
            messageLabel.Text = message;
            titleLabel.Text = title;
            okCancelPanel.Visible = true;
            itOK.Select();
            AutoAdjustFormSize(messageLabel);
        }

        private void AutoAdjustFormSize(Label label)
        {
            Size sz = TextRenderer.MeasureText(label.Text, label.Font, label.Size, TextFormatFlags.WordBreak);

            if (sz.Height > 94)
            {
                Size = new Size(Size.Width, sz.Height + 121);
            }
        }

        private void closingBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void yesOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closingBtn_MouseMove(object sender, MouseEventArgs e)
        {
            closingBtn.BackColor = Color.Red;
        }

        private void closingBtn_MouseLeave(object sender, EventArgs e)
        {
            closingBtn.BackColor = BackColor;
        }

        private bool tagMove;
        private int mValX, mValY;

        private void windowBar_MouseUp(object sender, MouseEventArgs e)
        {
            tagMove = false;
        }

        private void windowBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (tagMove)
            {
                SetDesktopLocation(MousePosition.X - mValX, MousePosition.Y - mValY);
            }
        }

        private void windowBar_MouseDown(object sender, MouseEventArgs e)
        {
            tagMove = true;
            mValX = e.X;
            mValY = e.Y;
        }
    }

    public static class CustomMessageBox
    {
        public static DialogResult Show (string message)
        {
            using (var form = new CustomMessageForm(message))
            {
                form.ShowDialog();
                return form.DialogResult;
            }
        }

        public static DialogResult Show (string message, string title)
        {
            using (var form = new CustomMessageForm(message, title))
            {
                form.ShowDialog();
                return form.DialogResult;
            }
        }

        public static DialogResult Show(string message, string title, MessageBoxButtons buttons)
        {
            using (var form = new CustomMessageForm(message, title, buttons))
            {
                form.ShowDialog();
                return form.DialogResult;
            }
        }
    }
}
