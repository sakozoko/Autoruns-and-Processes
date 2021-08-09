using System;
using System.Windows.Forms;

namespace Cleaner.Forms
{
    public enum IconFMessage
    {
        Exit = 0,
        Kill = 1,
        Notification = 2
    }
    public enum ButtonFMessage
    {
        Ok = 0,
        YesBack = 1
    }

    public partial class FMessage : Form
    {
        DialogResult _dialog;
        public FMessage()
        {
            InitializeComponent();
        }
        public FMessage(string textTitle, string textLabel, IconFMessage icon, ButtonFMessage button)
        {
            InitializeComponent();
            labelTitle.Text = textTitle;
            label.Text = textLabel;
            this.icon.Image = GetIcon(icon);
            GetButton(button);

        }

        private static System.Drawing.Bitmap GetIcon(IconFMessage icon)
        {
            switch (icon)
            {
                case IconFMessage.Exit:
                    return Properties.Resources.tryexit2;
                case IconFMessage.Kill:
                    return Properties.Resources.killbut;
                case IconFMessage.Notification:
                    return Properties.Resources.trynotification;
                default:
                    return Properties.Resources.trynotification;
            }
        }

        private void GetButton(ButtonFMessage button)
        {
            switch (button)
            {
                case ButtonFMessage.Ok:
                    butOK.Visible = true;
                    break;
                case ButtonFMessage.YesBack:
                    buttonYes.Visible = true;
                    buttonBack.Visible = true;
                    break;
            }
        }


        public DialogResult FShowDialog(Form parent)
        {
            GetStartPosition(parent);
            FormUpg.SmoothViewForm(this);
            ShowDialog();
            return _dialog;  
        }
        public DialogResult FShowDialog()
        {
            GetStartPosition(new Form());
            FormUpg.SmoothViewForm(this);
            ShowDialog();
            return _dialog;
        }
        private void GetStartPosition(Form parent)
        {
            StartPosition = parent.WindowState == FormWindowState.Minimized ? FormStartPosition.CenterScreen : FormStartPosition.CenterParent;
        }


        private void ButYes_Click(object sender, EventArgs e)
        {
            _dialog = DialogResult.Yes;
        }

        private void ButBack_Click(object sender, EventArgs e)
        {
            _dialog = DialogResult.No;
        }

        private void ButOK_Click(object sender, EventArgs e)
        {
            _dialog = DialogResult.OK;
        }

        private void FMessage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.None)
            {
                e.Cancel = true;
                FormUpg.SmoothViewFormClose(this);
            }
        }

        private void PanelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            FormUpg.FormMove.PanelTitle_MouseDown( e, this);
        }

        private void PanelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            FormUpg.FormMove.PanelTitle_MouseMove(sender, e);
        }
    }
}
