
namespace Cleaner.Forms
{
    partial class FMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMessage));
            this.buttonYes = new System.Windows.Forms.Button();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butOK = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.icon = new System.Windows.Forms.PictureBox();
            this.panelBody.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonYes
            // 
            this.buttonYes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.buttonYes.FlatAppearance.BorderSize = 0;
            this.buttonYes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.buttonYes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.buttonYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonYes.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonYes.Location = new System.Drawing.Point(11, 10);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(84, 30);
            this.buttonYes.TabIndex = 7;
            this.buttonYes.Text = "Да";
            this.buttonYes.UseVisualStyleBackColor = false;
            this.buttonYes.Visible = false;
            this.buttonYes.Click += new System.EventHandler(this.ButYes_Click);
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panelBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBody.Controls.Add(this.panel1);
            this.panelBody.Controls.Add(this.label);
            this.panelBody.Location = new System.Drawing.Point(0, 29);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(262, 137);
            this.panelBody.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.butOK);
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.buttonYes);
            this.panel1.Location = new System.Drawing.Point(-1, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 54);
            this.panel1.TabIndex = 10;
            // 
            // butOK
            // 
            this.butOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butOK.FlatAppearance.BorderSize = 0;
            this.butOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.butOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.butOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butOK.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.butOK.Location = new System.Drawing.Point(89, 10);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(84, 30);
            this.butOK.TabIndex = 9;
            this.butOK.Text = "Хорошо";
            this.butOK.UseVisualStyleBackColor = false;
            this.butOK.Visible = false;
            this.butOK.Click += new System.EventHandler(this.ButOK_Click);
            // 
            // label
            // 
            this.label.AutoEllipsis = true;
            this.label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(11, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(238, 79);
            this.label.TabIndex = 8;
            this.label.Text = "Вы действительно хотите выйти?";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(29, 6);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(44, 15);
            this.labelTitle.TabIndex = 9;
            this.labelTitle.Text = "Выход";
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Controls.Add(this.icon);
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(262, 30);
            this.panelTitle.TabIndex = 10;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitle_MouseDown);
            this.panelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelTitle_MouseMove);
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonBack.DialogResult = System.Windows.Forms.DialogResult.No;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.buttonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonBack.Location = new System.Drawing.Point(165, 10);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(84, 30);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Вернуться";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Visible = false;
            this.buttonBack.Click += new System.EventHandler(this.ButBack_Click);
            // 
            // icon
            // 
            this.icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.icon.ErrorImage = null;
            this.icon.Image = global::Cleaner.Properties.Resources.tryexit2;
            this.icon.InitialImage = null;
            this.icon.Location = new System.Drawing.Point(4, 2);
            this.icon.Margin = new System.Windows.Forms.Padding(0);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(23, 23);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.icon.TabIndex = 10;
            this.icon.TabStop = false;
            // 
            // FMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(262, 166);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelTitle);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FMessage";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FMessage_FormClosing);
            this.panelBody.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Button butOK;
        private System.Windows.Forms.Panel panel1;
    }
}