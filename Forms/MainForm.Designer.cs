
namespace Cleaner.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CleanProcessesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.icon = new System.Windows.Forms.PictureBox();
            this.butMaximize = new System.Windows.Forms.Button();
            this.butCloseProgram = new System.Windows.Forms.Button();
            this.butMinimize = new System.Windows.Forms.Button();
            this.panelFoot = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.butAutoRuns = new System.Windows.Forms.Button();
            this.butProcesses = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.autoRunGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ProcessNamesGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelBody = new System.Windows.Forms.Panel();
            this.butKillProcesses = new System.Windows.Forms.Button();
            this.butShowSavedProcesses = new System.Windows.Forms.Button();
            this.butRefreshProcessNames = new System.Windows.Forms.Button();
            this.butSaveProcessNames = new System.Windows.Forms.Button();
            this.contextMenuStrip.SuspendLayout();
            this.panelStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoRunGrid)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessNamesGrid)).BeginInit();
            this.panelBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipText = "Нажмите, чтобы отобразить";
            this.notifyIcon.BalloonTipTitle = "ShitCleaner";
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "ShitCleaner";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.contextMenuStrip.DropShadowEnabled = false;
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.CleanProcessesToolStripMenuItem,
            this.CloseToolStripMenuItem});
            this.contextMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip.ShowImageMargin = false;
            this.contextMenuStrip.ShowItemToolTips = false;
            this.contextMenuStrip.Size = new System.Drawing.Size(167, 70);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.OpenToolStripMenuItem.Text = "Открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // CleanProcessesToolStripMenuItem
            // 
            this.CleanProcessesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.CleanProcessesToolStripMenuItem.Name = "CleanProcessesToolStripMenuItem";
            this.CleanProcessesToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.CleanProcessesToolStripMenuItem.Text = "Почистить процессы";
            this.CleanProcessesToolStripMenuItem.Click += new System.EventHandler(this.CleanProcessesToolStripMenuItem_Click);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.AutoSize = false;
            this.CloseToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.CloseToolStripMenuItem.Text = "Закрыть";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseProgramToolStripMenuItem_Click);
            // 
            // panelStatus
            // 
            this.panelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStatus.Controls.Add(this.icon);
            this.panelStatus.Controls.Add(this.butMaximize);
            this.panelStatus.Controls.Add(this.butCloseProgram);
            this.panelStatus.Controls.Add(this.butMinimize);
            this.panelStatus.Location = new System.Drawing.Point(0, 0);
            this.panelStatus.Margin = new System.Windows.Forms.Padding(0);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(716, 30);
            this.panelStatus.TabIndex = 9;
            this.panelStatus.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PanelTitle_MouseDoubleClick);
            this.panelStatus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitle_MouseDown);
            this.panelStatus.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelTitle_MouseMove);
            // 
            // icon
            // 
            this.icon.Image = global::Cleaner.Properties.Resources.icon;
            this.icon.Location = new System.Drawing.Point(11, 0);
            this.icon.Name = "icon";
            this.icon.Padding = new System.Windows.Forms.Padding(5);
            this.icon.Size = new System.Drawing.Size(31, 30);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 9;
            this.icon.TabStop = false;
            // 
            // butMaximize
            // 
            this.butMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.butMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butMaximize.FlatAppearance.BorderSize = 0;
            this.butMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.butMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.butMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butMaximize.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.butMaximize.Location = new System.Drawing.Point(634, 0);
            this.butMaximize.Margin = new System.Windows.Forms.Padding(0);
            this.butMaximize.Name = "butMaximize";
            this.butMaximize.Size = new System.Drawing.Size(40, 30);
            this.butMaximize.TabIndex = 7;
            this.butMaximize.UseVisualStyleBackColor = false;
            this.butMaximize.Click += new System.EventHandler(this.ButMaximize_Click);
            // 
            // butCloseProgram
            // 
            this.butCloseProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butCloseProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.butCloseProgram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butCloseProgram.FlatAppearance.BorderSize = 0;
            this.butCloseProgram.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.butCloseProgram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.butCloseProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCloseProgram.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.butCloseProgram.Image = global::Cleaner.Properties.Resources.x;
            this.butCloseProgram.Location = new System.Drawing.Point(674, 0);
            this.butCloseProgram.Margin = new System.Windows.Forms.Padding(0);
            this.butCloseProgram.Name = "butCloseProgram";
            this.butCloseProgram.Size = new System.Drawing.Size(40, 30);
            this.butCloseProgram.TabIndex = 6;
            this.butCloseProgram.UseVisualStyleBackColor = false;
            this.butCloseProgram.Click += new System.EventHandler(this.ButCloseProgram_Click);
            // 
            // butMinimize
            // 
            this.butMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.butMinimize.FlatAppearance.BorderSize = 0;
            this.butMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.butMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.butMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butMinimize.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.butMinimize.Image = global::Cleaner.Properties.Resources.minus;
            this.butMinimize.Location = new System.Drawing.Point(594, 0);
            this.butMinimize.Name = "butMinimize";
            this.butMinimize.Size = new System.Drawing.Size(40, 30);
            this.butMinimize.TabIndex = 8;
            this.butMinimize.UseVisualStyleBackColor = false;
            this.butMinimize.Click += new System.EventHandler(this.ButMinimize_Click);
            // 
            // panelFoot
            // 
            this.panelFoot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelFoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFoot.Location = new System.Drawing.Point(0, 352);
            this.panelFoot.Name = "panelFoot";
            this.panelFoot.Size = new System.Drawing.Size(716, 32);
            this.panelFoot.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.butAutoRuns);
            this.panel2.Controls.Add(this.butProcesses);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(1, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(154, 351);
            this.panel2.TabIndex = 12;
            // 
            // butAutoRuns
            // 
            this.butAutoRuns.BackColor = System.Drawing.Color.Black;
            this.butAutoRuns.FlatAppearance.BorderSize = 0;
            this.butAutoRuns.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.butAutoRuns.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.butAutoRuns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAutoRuns.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAutoRuns.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.butAutoRuns.Location = new System.Drawing.Point(10, 30);
            this.butAutoRuns.Name = "butAutoRuns";
            this.butAutoRuns.Size = new System.Drawing.Size(135, 24);
            this.butAutoRuns.TabIndex = 11;
            this.butAutoRuns.Text = "Автозагрузка";
            this.butAutoRuns.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butAutoRuns.UseVisualStyleBackColor = false;
            this.butAutoRuns.Click += new System.EventHandler(this.AutoRuns_Click);
            // 
            // butProcesses
            // 
            this.butProcesses.BackColor = System.Drawing.Color.Black;
            this.butProcesses.FlatAppearance.BorderSize = 0;
            this.butProcesses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.butProcesses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.butProcesses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butProcesses.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butProcesses.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.butProcesses.Location = new System.Drawing.Point(10, 5);
            this.butProcesses.Name = "butProcesses";
            this.butProcesses.Size = new System.Drawing.Size(135, 24);
            this.butProcesses.TabIndex = 9;
            this.butProcesses.Text = "Процессы";
            this.butProcesses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butProcesses.UseVisualStyleBackColor = false;
            this.butProcesses.Click += new System.EventHandler(this.Processes_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.butKillProcesses);
            this.panel3.Controls.Add(this.butShowSavedProcesses);
            this.panel3.Controls.Add(this.butRefreshProcessNames);
            this.panel3.Controls.Add(this.butSaveProcessNames);
            this.panel3.Location = new System.Drawing.Point(-1, 293);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(156, 30);
            this.panel3.TabIndex = 11;
            this.panel3.Visible = false;
            // 
            // autoRunGrid
            // 
            this.autoRunGrid.AllowUserToAddRows = false;
            this.autoRunGrid.AllowUserToDeleteRows = false;
            this.autoRunGrid.AllowUserToResizeColumns = false;
            this.autoRunGrid.AllowUserToResizeRows = false;
            this.autoRunGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.autoRunGrid.BackgroundColor = System.Drawing.Color.Black;
            this.autoRunGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.autoRunGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.autoRunGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.autoRunGrid.ColumnHeadersVisible = false;
            this.autoRunGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.autoRunGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.autoRunGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.autoRunGrid.EnableHeadersVisualStyles = false;
            this.autoRunGrid.GridColor = System.Drawing.Color.Black;
            this.autoRunGrid.Location = new System.Drawing.Point(162, 8);
            this.autoRunGrid.MultiSelect = false;
            this.autoRunGrid.Name = "autoRunGrid";
            this.autoRunGrid.ReadOnly = true;
            this.autoRunGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.autoRunGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.autoRunGrid.RowHeadersVisible = false;
            this.autoRunGrid.RowHeadersWidth = 40;
            this.autoRunGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.autoRunGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.autoRunGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.autoRunGrid.ShowCellErrors = false;
            this.autoRunGrid.ShowCellToolTips = false;
            this.autoRunGrid.ShowEditingIcon = false;
            this.autoRunGrid.ShowRowErrors = false;
            this.autoRunGrid.Size = new System.Drawing.Size(551, 311);
            this.autoRunGrid.TabIndex = 14;
            this.autoRunGrid.Visible = false;
            this.autoRunGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AutoRunGrid_CellClick);
            this.autoRunGrid.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.AutoRunGrid_CellMouseEnter);
            this.autoRunGrid.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.AutoRunGrid_CellMouseLeave);
            this.autoRunGrid.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.AutoRunGrid_CellStateChanged);
            // 
            // Column1
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 390;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.ProcessNamesGrid);
            this.panel4.Location = new System.Drawing.Point(155, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(559, 323);
            this.panel4.TabIndex = 15;
            this.panel4.Visible = false;
            // 
            // ProcessNamesGrid
            // 
            this.ProcessNamesGrid.AllowUserToAddRows = false;
            this.ProcessNamesGrid.AllowUserToDeleteRows = false;
            this.ProcessNamesGrid.AllowUserToResizeColumns = false;
            this.ProcessNamesGrid.AllowUserToResizeRows = false;
            this.ProcessNamesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProcessNamesGrid.BackgroundColor = System.Drawing.Color.Black;
            this.ProcessNamesGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.ProcessNamesGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ProcessNamesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProcessNamesGrid.ColumnHeadersVisible = false;
            this.ProcessNamesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProcessNamesGrid.DefaultCellStyle = dataGridViewCellStyle9;
            this.ProcessNamesGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.ProcessNamesGrid.EnableHeadersVisualStyles = false;
            this.ProcessNamesGrid.GridColor = System.Drawing.Color.Black;
            this.ProcessNamesGrid.Location = new System.Drawing.Point(2, 5);
            this.ProcessNamesGrid.MultiSelect = false;
            this.ProcessNamesGrid.Name = "ProcessNamesGrid";
            this.ProcessNamesGrid.ReadOnly = true;
            this.ProcessNamesGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProcessNamesGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.ProcessNamesGrid.RowHeadersVisible = false;
            this.ProcessNamesGrid.RowHeadersWidth = 30;
            this.ProcessNamesGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ProcessNamesGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ProcessNamesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ProcessNamesGrid.ShowCellErrors = false;
            this.ProcessNamesGrid.ShowCellToolTips = false;
            this.ProcessNamesGrid.ShowEditingIcon = false;
            this.ProcessNamesGrid.ShowRowErrors = false;
            this.ProcessNamesGrid.Size = new System.Drawing.Size(556, 311);
            this.ProcessNamesGrid.TabIndex = 15;
            this.ProcessNamesGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProcessNamesGrid_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.NullValue = false;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn1.Width = 20;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn2.HeaderText = "Column2";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Width = 390;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(155, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 324);
            this.panel1.TabIndex = 1;
            // 
            // panelBody
            // 
            this.panelBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBody.BackColor = System.Drawing.Color.Black;
            this.panelBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBody.Controls.Add(this.panel1);
            this.panelBody.Controls.Add(this.panel4);
            this.panelBody.Controls.Add(this.autoRunGrid);
            this.panelBody.Controls.Add(this.panel2);
            this.panelBody.Location = new System.Drawing.Point(0, 26);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(716, 327);
            this.panelBody.TabIndex = 5;
            // 
            // butKillProcesses
            // 
            this.butKillProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.butKillProcesses.BackColor = System.Drawing.Color.Black;
            this.butKillProcesses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butKillProcesses.FlatAppearance.BorderSize = 0;
            this.butKillProcesses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.butKillProcesses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.butKillProcesses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butKillProcesses.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.butKillProcesses.Image = global::Cleaner.Properties.Resources.killbut;
            this.butKillProcesses.Location = new System.Drawing.Point(109, -1);
            this.butKillProcesses.Name = "butKillProcesses";
            this.butKillProcesses.Size = new System.Drawing.Size(30, 30);
            this.butKillProcesses.TabIndex = 17;
            this.butKillProcesses.UseVisualStyleBackColor = false;
            this.butKillProcesses.Click += new System.EventHandler(this.KillProcessNames_Click);
            // 
            // butShowSavedProcesses
            // 
            this.butShowSavedProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.butShowSavedProcesses.BackColor = System.Drawing.Color.Black;
            this.butShowSavedProcesses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butShowSavedProcesses.FlatAppearance.BorderSize = 0;
            this.butShowSavedProcesses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.butShowSavedProcesses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.butShowSavedProcesses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butShowSavedProcesses.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.butShowSavedProcesses.Image = global::Cleaner.Properties.Resources.savedbut;
            this.butShowSavedProcesses.Location = new System.Drawing.Point(78, -1);
            this.butShowSavedProcesses.Name = "butShowSavedProcesses";
            this.butShowSavedProcesses.Size = new System.Drawing.Size(30, 30);
            this.butShowSavedProcesses.TabIndex = 16;
            this.butShowSavedProcesses.UseVisualStyleBackColor = false;
            this.butShowSavedProcesses.Click += new System.EventHandler(this.ShowSavedProcessNames_Click);
            // 
            // butRefreshProcessNames
            // 
            this.butRefreshProcessNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.butRefreshProcessNames.BackColor = System.Drawing.Color.Black;
            this.butRefreshProcessNames.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butRefreshProcessNames.FlatAppearance.BorderSize = 0;
            this.butRefreshProcessNames.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.butRefreshProcessNames.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.butRefreshProcessNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butRefreshProcessNames.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.butRefreshProcessNames.Image = global::Cleaner.Properties.Resources.refreshbut;
            this.butRefreshProcessNames.Location = new System.Drawing.Point(16, -1);
            this.butRefreshProcessNames.Name = "butRefreshProcessNames";
            this.butRefreshProcessNames.Size = new System.Drawing.Size(30, 30);
            this.butRefreshProcessNames.TabIndex = 14;
            this.butRefreshProcessNames.UseVisualStyleBackColor = false;
            this.butRefreshProcessNames.Click += new System.EventHandler(this.RefreshProcessNames_Click);
            // 
            // butSaveProcessNames
            // 
            this.butSaveProcessNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.butSaveProcessNames.BackColor = System.Drawing.Color.Black;
            this.butSaveProcessNames.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butSaveProcessNames.FlatAppearance.BorderSize = 0;
            this.butSaveProcessNames.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.butSaveProcessNames.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.butSaveProcessNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSaveProcessNames.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.butSaveProcessNames.Image = global::Cleaner.Properties.Resources.savebut;
            this.butSaveProcessNames.Location = new System.Drawing.Point(47, -1);
            this.butSaveProcessNames.Name = "butSaveProcessNames";
            this.butSaveProcessNames.Size = new System.Drawing.Size(30, 30);
            this.butSaveProcessNames.TabIndex = 15;
            this.butSaveProcessNames.UseVisualStyleBackColor = false;
            this.butSaveProcessNames.Click += new System.EventHandler(this.SaveProcessNames_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(716, 384);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelFoot);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 984);
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0D;
            this.Text = "Cleaner";
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.panelStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.autoRunGrid)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProcessNamesGrid)).EndInit();
            this.panelBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button butCloseProgram;
        private System.Windows.Forms.Button butMaximize;
        private System.Windows.Forms.Button butMinimize;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CleanProcessesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.Panel panelFoot;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button butAutoRuns;
        private System.Windows.Forms.Button butProcesses;
        private System.Windows.Forms.DataGridView autoRunGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.DataGridView ProcessNamesGrid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button butKillProcesses;
        private System.Windows.Forms.Button butShowSavedProcesses;
        private System.Windows.Forms.Button butRefreshProcessNames;
        private System.Windows.Forms.Button butSaveProcessNames;
    }
}

