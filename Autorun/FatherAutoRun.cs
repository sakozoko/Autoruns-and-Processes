using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Win32;
namespace Cleaner.Autorun
{
    internal abstract class FatherAutoRun
    {

        protected readonly string[] PathRegistryAutoRun = { @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run",
                @"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Run"};
        protected readonly string PathSystemTasks = Environment.GetFolderPath(Environment.SpecialFolder.Windows) + @"\System32\Tasks\";
        protected const string PathExplorerStartupApproved = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\StartupApproved";
        protected const byte IsActivated = 2;
        protected static Dictionary<string, string> AutoRunFolderKey = new Dictionary<string, string>();
        protected Dictionary<string, string> _resultAutoRun;
        public Dictionary<string, string> ResultAutoRun => _resultAutoRun;
        protected List<string> GetNamesFolderToFind()
        {
            var namesFolder = new List<string>();
            using (RegistryKey keyFold = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(PathExplorerStartupApproved))
            {
                namesFolder.AddRange(keyFold?.GetSubKeyNames() ?? Array.Empty<string>() );
            }
            using (RegistryKey keyFold = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(PathExplorerStartupApproved))
            {
                namesFolder.AddRange(keyFold?.GetSubKeyNames() ?? Array.Empty<string>()); 
            }
            return namesFolder;
        }
        public virtual string GetPath(string name)
        {
            return AutoRunFolderKey[AutoRunFolderKey.Keys.First(x => x == name)];
        }

        public abstract void UpdateAutoRunsDictionary();
        protected abstract Dictionary<string, string> GetAutoRun();
        public abstract void TurnOnAutoRun(string name);
        public abstract bool TryFindActivate(string name);

    }
}

