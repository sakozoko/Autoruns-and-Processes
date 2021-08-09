using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cleaner.Process;
using Cleaner.Properties;
using Timer = System.Windows.Forms.Timer;

namespace Cleaner.Forms
{
    public class FormUpg
    {
        private static EventHandler _eventHandler;

        private static void StartTimer(EventHandler method, Form myForm)
        {
            var timer = new Timer();
            method += (s, e) =>
            {
                if (Math.Abs(myForm.Opacity - 1) == 0 || myForm.Opacity == 0) timer.Stop();
            };
            method += _eventHandler;
            timer.Tick += method;
            timer.Interval = 10;
            timer.Start();
        }

        public static void SmoothViewForm(Form myForm)
        {
            if (myForm.Opacity == 0)
            {
                _eventHandler += (s, e) => { myForm.Opacity += 0.05; };
                StartTimer(_eventHandler, myForm);
            }
            else
            {
                _eventHandler += (s, e) => { myForm.Opacity -= 0.05; };
                StartTimer(_eventHandler, myForm);
            }
        }


        public static void SmoothViewFormClose(Form myForm)
        {
            if (Math.Abs(myForm.Opacity - 1) > 0) return;
            _eventHandler = (s, e) =>
            {
                if (myForm.Opacity == 0) myForm.Close();
            };
            SmoothViewForm(myForm);
        }


        public static void SmoothViewFormMinNorm(Form myForm)
        {
            if (myForm.Opacity == 0)
            {
                _eventHandler = (s, e) => { myForm.WindowState = FormWindowState.Normal; };
                SmoothViewForm(myForm);
            }
            else
            {
                _eventHandler = (s, e) =>
                {
                    if (myForm.Opacity == 0) myForm.WindowState = FormWindowState.Minimized;
                };
                SmoothViewForm(myForm);
            }
        }

        private static Task _task;
        public static void RewriteProcessNamesToGrid(DataGridView dataGrid, Form myForm)
        {
            if (_task != null)
                    if (_task.Status == TaskStatus.Running)
                        return;
            _task = Task.Run(() =>
            {
                var processNames = dataGrid.FindForm()?.Name == "MainForm"
                    ? ProcessNames.GetActivatedProcessNames().ToHashSet()
                    : ProcessNames.GetSavedProcNames().ToHashSet();
                for (var c = 0; c < dataGrid.Rows.Count; c++)
                {
                    if (processNames.Contains(dataGrid[1, c].Value.ToString())) continue;
                    var i = c;
                    myForm.Invoke((Action) (() => dataGrid.Rows.RemoveAt(i--)));
                    c = i;
                }

                foreach (var procName in processNames
                    .Where(procName => !dataGrid.GetList().Contains(procName)))
                {
                    myForm.Invoke((Action) (() => dataGrid.Rows.Add(false, procName)));
                }

                myForm.Invoke((Action) dataGrid.SetChecks);
                Thread.Sleep(1000);
            });
        }

        public class FormMove
        {
            private static Point _point;
            private static Form _form;
            public static void PanelTitle_MouseDown(MouseEventArgs e, Form myForm)
            {
                _form = myForm;
                _point.X = e.X;
                _point.Y = e.Y;
            }


            public static void PanelTitle_MouseMove(object sender, MouseEventArgs e)
            {
                if (e.Button != MouseButtons.Left) return;
                _form.Left = _form.Left + e.X - _point.X;
                _form.Top = _form.Top + e.Y - _point.Y;
            }
        }
    }
}