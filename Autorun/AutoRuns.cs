using Cleaner.Forms;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cleaner.Autorun
{
    internal static class AutoRuns
    {
        private static FatherAutoRun _autoRunFromStartup;
        private static FatherAutoRun _autoRunFromRegistry;
        private static FatherAutoRun _autoRunFromScheduler;

        public static Dictionary<string, string> GetAutoRuns()
        {
            CreateAutoRunsInstance();
            UpdateAutoRuns();
            var result = _autoRunFromRegistry.ResultAutoRun.Union(_autoRunFromStartup.ResultAutoRun)
                .Union(_autoRunFromScheduler.ResultAutoRun).ToDictionary(x => x.Key, x => x.Value);
            return result;
        }

        private static void UpdateAutoRuns()
        {
            _autoRunFromRegistry.UpdateAutoRunsDictionary();
            _autoRunFromScheduler.UpdateAutoRunsDictionary();
            _autoRunFromStartup.UpdateAutoRunsDictionary();
        }
        private static void CreateAutoRunsInstance()
        {
            _autoRunFromRegistry = Registry.Create();
            _autoRunFromScheduler = TaskScheduler.Create();
            _autoRunFromStartup = Startup.Create();
        }
        private static FatherAutoRun ReturnCorrectAutoRun(string name)
        {
            if (_autoRunFromStartup.ResultAutoRun.Keys.Any(nam => name == nam))
            {
                return Registry.Create();
            }
            if (_autoRunFromScheduler.ResultAutoRun.Keys.Any(nam => name == nam))
            {
                return TaskScheduler.Create();
            }
            if (_autoRunFromRegistry.ResultAutoRun.Keys.Any(nam => name == nam))
            {
                return Startup.Create();
            }
            return Registry.Create();
        }
        public static bool ActivatedAutoRun(string name)
        {
            var autoRun = ReturnCorrectAutoRun(name);
            var result = autoRun.TryFindActivate(name);
            return result;
        }
        public static void TurnOnAutoRun(string name)
        {
            var myAutoRun = ReturnCorrectAutoRun(name);
            try
            {
                myAutoRun.TurnOnAutoRun(name);
            }
            catch(Exception e)
            {
                new FMessage("Error", e.Message, IconFMessage.Notification, ButtonFMessage.Ok).FShowDialog();
                var fMessage =  new FMessage("Путь, где лежит автозагрузка", "\""+myAutoRun.GetPath(name)+"\" - скопировать?",
                    IconFMessage.Notification, ButtonFMessage.YesBack);
                if(fMessage.FShowDialog()==System.Windows.Forms.DialogResult.Yes)
                    System.Windows.Forms.Clipboard.SetText(myAutoRun.GetPath(name));
            }
        }

    }
}
