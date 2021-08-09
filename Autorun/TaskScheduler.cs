using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml;

namespace Cleaner.Autorun
{
    internal class TaskScheduler : FatherAutoRun
    {
        private TaskScheduler()
        {
        }

        private static TaskScheduler Instance { get; } = new TaskScheduler();

        public static TaskScheduler Create()
        {
            return Instance;
        }

        public override void UpdateAutoRunsDictionary()
        {
            GetAutoRun();
        }
        private const string PathTaskSchedulerBoot = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Schedule\TaskCache\Boot";

        private const string PathTaskSchedulerLogon = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Schedule\TaskCache\Logon";

        private const string PathTaskSchedulerTree = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Schedule\TaskCache\Tree";

        public override bool TryFindActivate(string name)
        {
            var result = true;
            var taskXml = new XmlDocument();
            taskXml.Load(PathSystemTasks + name);
            if ((from XmlNode xmlNode in taskXml.DocumentElement
                 where xmlNode.Name == "Settings"
                 from XmlNode child in xmlNode.ChildNodes
                 where child.Name == "Enabled"
                 select child.InnerText).Any(x => x == "false"))
                result = false;
            return result;
        }

        protected override Dictionary<string, string> GetAutoRun()
        {
            var tasksKeys = new List<string>();
            using (var key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(PathTaskSchedulerLogon))
            {
                tasksKeys.AddRange(key?.GetSubKeyNames() ?? Array.Empty<string>());
            }

            using (var key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(PathTaskSchedulerBoot))
            {
                tasksKeys.AddRange(key?.GetSubKeyNames() ?? Array.Empty<string>());
            }

            var namesAutoRun = new List<string>();
            using (var key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(PathTaskSchedulerTree))
            {
                namesAutoRun.AddRange(key?.GetSubKeyNames() ?? Array.Empty<string>());
            }

            var dict = new Dictionary<string, string>();
            foreach (var path in namesAutoRun)
                using (var key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(PathTaskSchedulerTree + @"\" + path))
                {
                    if (key?.GetValue("id") is null) continue;
                    if (tasksKeys.All(shh => key.GetValue("id").ToString().Replace("\0", "") != shh)) continue;
                    dict.Add(key.GetValue("id").ToString().Replace("\0", ""), path);
                    if (!AutoRunFolderKey.Keys.Contains(path))
                        AutoRunFolderKey.Add(path, PathTaskSchedulerTree + @"\" + path);
                }

            var cmd = new List<string>();
            foreach (var path in dict.Values)
            {
                var xDoc = new XmlDocument();
                xDoc.Load(PathSystemTasks + path);
                cmd.AddRange(from XmlNode node in xDoc.DocumentElement
                             from XmlNode xmlNode in node.ChildNodes
                             from XmlNode child in xmlNode.ChildNodes
                             where child.Name == "Command"
                             select child.InnerText);
            }

            var resultDictionary = new Dictionary<string, string>();
            var i = 0;
            foreach (var res in dict.Keys)
            {
                resultDictionary.Add(dict[res], cmd[i]);
                i++;
            }

            _resultAutoRun = resultDictionary;
            return resultDictionary;
        }

        public override void TurnOnAutoRun(string name)
        {
            var activate = TryFindActivate(name);
            var command = "/c schtasks /Change /TN \"" + name + "\" ";
            if (activate)
                command += "/DISABLE";
            else
                command += "/ENABLE";
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = command,
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true
            })
                ?.WaitForExit();
            if (activate == TryFindActivate(name))
                throw new Exception("Ошибка изменения состояния автозагрузки, возможно, неактивная запись в реестре");
        }

    }
}