using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cleaner.Properties;
using Cleaner.Process;
using Cleaner.Autorun;
namespace Cleaner.Forms
{
    internal partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CreateImagesButtonMaximize();
            FormUpg.SmoothViewForm(this);
        }


        private void CreateImagesButtonMaximize()
        {
            var imgList = new ImageList();
            imgList.Images.AddRange(new System.Drawing.Image[] {
                Resources.maximum,
                Resources.minimum
            });
            butMaximize.ImageList = imgList;
            butMaximize.ImageIndex = 0;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FormUpg.RewriteProcessNamesToGrid(ProcessNamesGrid,this);
            AddAutoRuns();
            ShowActivatedAutoRuns();

        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized) return;
            notifyIcon.Visible = true;
            ShowInTaskbar = false;
        }

        private void CleanProcessesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BeforeClean();
        }

        private void BeforeClean()
        {

            var fMessage = new FMessage("Закрыть процессы",
                $"Вы действительно хотите закрыть ({ProcessNamesGrid.GetTextCheckedCells().Count})",
                IconFMessage.Kill, ButtonFMessage.YesBack);
            if (fMessage.FShowDialog(this) == DialogResult.Yes)
            {
                CleanProc();
            }
        }

        private void CleanProc()
        {
            ProcessNames.AddProcNames(ProcessNamesGrid.GetTextCheckedCells());
            Processes.ProcessesKill(ProcessNamesGrid.GetTextCheckedCells());
            new FMessage("Готово", "Процессы были удалены", IconFMessage.Kill, ButtonFMessage.Ok).FShowDialog(this);
            FormUpg.RewriteProcessNamesToGrid(ProcessNamesGrid,this);
        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenToolStripMenuItem_Click(sender, e);
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUpg.SmoothViewFormMinNorm(this);
            notifyIcon.Visible = false;
            ShowInTaskbar = true;
            butMinimize.Enabled = true;
        }

        private void CloseProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButCloseProgram_Click(object sender, EventArgs e)
        {
            ProcessNamesGrid.Focus();
            var fMessage = new FMessage("Выход", "Вы действительно хотите выйти?", IconFMessage.Exit, ButtonFMessage.YesBack);
            if (fMessage.FShowDialog(this) == DialogResult.Yes)
            {
                FormUpg.SmoothViewFormClose(this);
            }
        }

        private void ButMaximize_Click(object sender, EventArgs e)
        {
            ChangeIndexImageButMaximize();
            WindowState = (butMaximize.ImageIndex == 1) ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        private void ChangeIndexImageButMaximize()
        {
            butMaximize.ImageIndex = (butMaximize.ImageIndex == 1) ? 0 : 1;
        }
        private void ButMinimize_Click(object sender, EventArgs e)
        {
            FormUpg.SmoothViewFormMinNorm(this);
            butMinimize.Enabled = false;
        }

        private void PanelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            FormUpg.FormMove.PanelTitle_MouseDown(e, this);
        }

        private void PanelTitle_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ChangeIndexImageButMaximize();
            WindowState = (butMaximize.ImageIndex == 1) ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        private void PanelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            FormUpg.FormMove.PanelTitle_MouseMove(sender, e);
        }

        private void DeactivateAllButtonsOnMenu()
        {
            foreach (Control control in panel2.Controls)
            {
                if (!(control is Button button)) continue;
                button.ForeColor = System.Drawing.Color.Gray;
                button.BackColor = System.Drawing.Color.Black;
            }
        }

        private static void ActivateButtonOnMenu(Button button)
        {
            button.ForeColor = System.Drawing.Color.White;
            button.BackColor = System.Drawing.Color.FromArgb(55, 55, 55);
        }

        private void Processes_Click(object sender, EventArgs e)
        {
            DeactivateAllButtonsOnMenu();
            ActivateButtonOnMenu(sender as Button);
            panel4.Visible = true;
            panel3.Visible = true;
            autoRunGrid.Visible = false;
        }

        private void ShowActivatedAutoRuns()
        {
            for (int c = 0; c < autoRunGrid.Rows.Count; c++)
            {
                if (!AutoRuns.ActivatedAutoRun(autoRunGrid.Rows[c].Cells[0].Value.ToString()))
                {
                    for (int i = 0; i < autoRunGrid.Columns.Count; i++)
                        autoRunGrid.Rows[c].Cells[i].Style.ForeColor = System.Drawing.Color.Gray;
                }
                else
                {
                    for (int i = 0; i < autoRunGrid.Columns.Count; i++)
                        autoRunGrid.Rows[c].Cells[i].Style.ForeColor = System.Drawing.Color.White;
                }
            }
        }

        private static Task  _task;
        private void AddAutoRunsAsync()
        {
            if (_task != null)
                if (_task.Status == TaskStatus.Running)
                    return;

            _task =  Task.Run(() =>
            {
                var flag = true;
                while (flag)
                {

                    if (InvokeRequired)
                        Invoke((Action)(() =>
                        {
                            if (autoRunGrid.Visible)
                            {
                                AddAutoRuns();
                                ShowActivatedAutoRuns();
                            }
                            else flag = false;
                        }));
                    else
                    {
                        if (autoRunGrid.Visible)
                        {
                            AddAutoRuns();
                            ShowActivatedAutoRuns();
                        }
                        else flag = false;
                    }
                    Thread.Sleep(1000);
                }
            });
        }

        private void AddAutoRuns()
        {
            var autoRuns = AutoRuns.GetAutoRuns();

            for (var c = 0; c < autoRunGrid.Rows.Count; c++)
            {
                if (!autoRuns.ContainsKey(autoRunGrid.Rows[c].Cells[0].Value.ToString()) ||
                    !autoRuns.ContainsValue(autoRunGrid.Rows[c].Cells[1].Value.ToString()))
                    autoRunGrid.Rows.RemoveAt(c--);
            }
            
            for (var c = 0; c < autoRunGrid.Rows.Count; c++)
            {
                if(autoRuns.ContainsKey(autoRunGrid.Rows[c].Cells[0].Value.ToString()))
                {
                    autoRuns.Remove(autoRunGrid.Rows[c].Cells[0].Value.ToString());
                }
            }
            foreach (var re in autoRuns.Keys)
            {

                autoRunGrid.Rows.Add(re, autoRuns[re]);
            }
        }

        private void AutoRuns_Click(object sender, EventArgs e)
        {
            DeactivateAllButtonsOnMenu();
            ActivateButtonOnMenu(sender as Button);
            panel4.Visible = false;
            panel3.Visible = false;
            autoRunGrid.Visible = true;
            AddAutoRunsAsync();
        }

        private void AutoRunGrid_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 )
                    autoRunGrid.Rows[e.RowIndex].Cells[0].Style.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
        }

        private void AutoRunGrid_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
                    autoRunGrid.Rows[e.RowIndex].Cells[0].Style.BackColor = System.Drawing.Color.Black;
        }

        private void AutoRunGrid_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            e.Cell.Selected = false;
        }

        private void AutoRunGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var p = autoRunGrid.Rows[e.RowIndex].Cells[0].Style.ForeColor;
            if (e.ColumnIndex != 0) return;
            AutoRuns.TurnOnAutoRun(autoRunGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            for (int i = 0; i < autoRunGrid.Columns.Count; i++)
            {
                autoRunGrid.Rows[e.RowIndex].Cells[i].Style.ForeColor =
                    (p == System.Drawing.Color.Gray) ? System.Drawing.Color.White : System.Drawing.Color.Gray;
            }
        }

        private void KillProcessNames_Click(object sender, EventArgs e)
        {
            BeforeClean();
        }

        private void ShowSavedProcessNames_Click(object sender, EventArgs e)
        {
            new FSavedProc().ShowDialog();
        }

        private void RefreshProcessNames_Click(object sender, EventArgs e)
        {
            FormUpg.RewriteProcessNamesToGrid(ProcessNamesGrid,this);
        }

        private void SaveProcessNames_Click(object sender, EventArgs e)
        {
            ProcessNames.AddProcNames(ProcessNamesGrid.GetTextCheckedCells());
        }

        private void ProcessNamesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            { ProcessNamesGrid.Rows[e.RowIndex].Cells[0].Value = !(bool)ProcessNamesGrid.Rows[e.RowIndex].Cells[0].Value; }
        }
    }



}
