using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Cleaner.Forms;

namespace Cleaner.Process
{
    public class Processes
    {
        public static void ProcessesKill(HashSet<string> processNames)
        {
            try
            {
                processNames.ToList().ForEach(x=> System.Diagnostics.Process.GetProcessesByName(x).ToList().ForEach(p=>p.Kill()));
            }
            catch (Win32Exception)
            {
                new FMessage("Отказано в доступе", "Запустите приложение от имени администратора!",
                    IconFMessage.Notification, ButtonFMessage.Ok).ShowDialog();
            }
        }
    }
}