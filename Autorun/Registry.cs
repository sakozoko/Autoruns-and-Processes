using System;
using System.Collections.Generic;
using System.Linq;

namespace Cleaner.Autorun
{
    internal class Registry : FatherAutoRun
    {
        private Registry()
        {
        }

        private static Registry Instance { get; } = new Registry();

        public static Registry Create()
        {
            return Instance;
        }

        public override void UpdateAutoRunsDictionary()
        {
            GetAutoRun();
        }
        private static readonly Dictionary<string, string> AutoRunFolderKeyActive = new Dictionary<string, string>();

        protected override Dictionary<string, string> GetAutoRun()
        {
            AutoRunFolderKey.Clear();
            var dict = new Dictionary<string, string>();
            foreach (var path in PathRegistryAutoRun)
            {
                using (var key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(path))
                {
                    if (!(key is null))
                        foreach (var s in key.GetValueNames())
                        {
                            dict.Add(s, key.GetValue(s).ToString());
                            if (!AutoRunFolderKey.Keys.Contains(path))
                                AutoRunFolderKey.Add(s, @"LocalMachine\" + path);
                        }
                }

                using (var key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(path))
                {
                    if (key is null) continue;
                    foreach (var s in key.GetValueNames())
                    {
                        dict.Add(s, key.GetValue(s).ToString());
                        if (!AutoRunFolderKey.Keys.Contains(path))
                            AutoRunFolderKey.Add(s, @"CurrentUser\" + path);
                    }
                }
            }

            _resultAutoRun = dict;
            return dict;
        }

        public override bool TryFindActivate(string name)
        {
            var result = true;
            var namesFolder = GetNamesFolderToFind();
            foreach (var nameFolder in namesFolder)
            {
                using (var key =
                    Microsoft.Win32.Registry.CurrentUser.OpenSubKey(PathExplorerStartupApproved + @"\" + nameFolder))
                {
                    if (!(key is null))
                        if (key.GetValueNames().Contains(name))
                        {
                            var ss = (byte[]) key.GetValue(name);
                            if (IsActivated != ss[0]) result = false;
                            if (!AutoRunFolderKeyActive.Keys.Contains(name))
                                AutoRunFolderKeyActive.Add(name,
                                    @"CurrentUser\" + PathExplorerStartupApproved + @"\" + nameFolder);
                        }
                }

                using (var key =
                    Microsoft.Win32.Registry.LocalMachine.OpenSubKey(PathExplorerStartupApproved + @"\" + nameFolder))
                {
                    if (!(key is null))
                        if (key.GetValueNames().Contains(name))
                        {
                            var ss = (byte[]) key.GetValue(name);
                            if (IsActivated != ss[0]) result = false;
                            if (!AutoRunFolderKeyActive.Keys.Contains(name))
                                AutoRunFolderKeyActive.Add(name,
                                    @"LocalMachine\" + PathExplorerStartupApproved + @"\" + nameFolder);
                        }
                }

                string folder ="";
                try
                {
                    folder = AutoRunFolderKey[name].Contains("LocalMachine") ? @"LocalMachine\" : @"CurrentUser\";
                }
                catch(KeyNotFoundException)
                {}

                if (!AutoRunFolderKey[name].EndsWith(nameFolder) ||
                    AutoRunFolderKeyActive.Keys.Contains(name)) continue;
                var value = folder + PathExplorerStartupApproved + @"\" + nameFolder;
                value += AutoRunFolderKey[name].Contains("Wow6432Node") ? "32" : "";
                AutoRunFolderKeyActive.Add(name, value);
            }

            return result;
        }

        public override void TurnOnAutoRun(string name)
        {
            var act = TryFindActivate(name);
            foreach (var s in AutoRunFolderKeyActive.Keys.Where(s => name == s))
                if (AutoRunFolderKeyActive[s].Contains("LocalMachine"))
                    using (var key =
                        Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                            AutoRunFolderKeyActive[s].Replace(@"LocalMachine\", ""), true))
                    {
                        if (act)
                        {
                            byte[] bytes = {3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
                            key?.SetValue(name, bytes);
                        }
                        else
                        {
                            byte[] bytes = {2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
                            key?.SetValue(name, bytes);
                        }
                    }
                else
                    using (var key =
                        Microsoft.Win32.Registry.CurrentUser.OpenSubKey(
                            AutoRunFolderKeyActive[s].Replace(@"CurrentUser\", ""), true))
                    {
                        if (act)
                        {
                            byte[] bytes = {3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
                            key?.SetValue(name, bytes);
                        }
                        else
                        {
                            byte[] bytes = {2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
                            key?.SetValue(name, bytes);
                        }
                    }

            if (act == TryFindActivate(name))
                throw new Exception("Ошибка изменения состояния автозагрузки, возможно, неактивная запись в реестре");
        }
    }
}