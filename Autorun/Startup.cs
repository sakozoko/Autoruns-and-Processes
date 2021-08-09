using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Cleaner.Autorun
{
    internal class Startup : FatherAutoRun
    {
        private Startup()
        {
        }

        private static Startup Instance { get; } = new Startup();

        public static Startup Create()
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
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            var namesFromUserStartup = new List<string>();
            var namesFromCommonStartup = new List<string>();
            namesFromUserStartup.AddRange(Directory.GetFiles(path));

            var dict = new Dictionary<string, string>();
            foreach (var sss in namesFromUserStartup.Where(sss => !(sss is null) && sss.Contains(".lnk")))
            {
                dict.Add(sss.Replace(path + @"\", "").Replace(".lnk", ""), sss);
                if (!AutoRunFolderKey.Keys.Contains(path))
                    AutoRunFolderKey.Add(sss.Replace(path + @"\", "").Replace(".lnk", ""),
                        @"CurrentUser\" + PathExplorerStartupApproved + @"\StartupFolder");
            }

            path = Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup);
            namesFromCommonStartup.AddRange(Directory.GetFiles(path));
            foreach (var sss in namesFromCommonStartup.Where(sss => !(sss is null) && sss.Contains(".lnk")))
            {
                dict.Add(sss.Replace(path + @"\", "").Replace(".lnk", ""), sss);
                if (!AutoRunFolderKey.Keys.Contains(path))
                    AutoRunFolderKey.Add(sss.Replace(path + @"\", "").Replace(".lnk", ""),
                        @"LocalMachine\" + PathExplorerStartupApproved + @"\StartupFolder");
            }

            _resultAutoRun = dict;
            return dict;
        }

        public override bool TryFindActivate(string name)
        {
            var result = true;
            if (AutoRunFolderKey[name].Contains("CurrentUser"))
                using (var key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(PathExplorerStartupApproved + @"\StartupFolder"))
                {
                    if (key is null) return true;
                    if (!key.GetValueNames().Contains(name + ".lnk")) return true;
                    var bytes = (byte[]) key.GetValue(name + ".lnk");
                    if (IsActivated != bytes[0]) result = false;
                    if (!AutoRunFolderKeyActive.Keys.Contains(name + ".lnk"))
                        AutoRunFolderKeyActive.Add(name + ".lnk",
                            @"CurrentUser\" + PathExplorerStartupApproved + @"\StartupFolder");
                }
            else
                using (var key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(PathExplorerStartupApproved + @"\StartupFolder"))
                {
                    if (key is null) return true;
                    if (key.GetValueNames().Contains(name + ".lnk"))
                    {
                        var ss = (byte[]) key.GetValue(name + ".lnk");
                        if (IsActivated != ss[0]) result = false;
                        if (!AutoRunFolderKeyActive.Keys.Contains(name + ".lnk"))
                            AutoRunFolderKeyActive.Add(name + ".lnk",
                                @"LocalMachine\" + PathExplorerStartupApproved + @"\StartupFolder");
                    }
                }

            return result;
        }

        public override void TurnOnAutoRun(string name)
        {
            var activate = TryFindActivate(name);
            if (AutoRunFolderKey[name].Contains("LocalMachine"))
                using (var key =
                    Microsoft.Win32.Registry.LocalMachine.OpenSubKey(PathExplorerStartupApproved + @"\StartupFolder", true))
                {
                    if (activate)
                    {
                        byte[] code = {3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
                        key?.SetValue(name + ".lnk", code);
                    }
                    else
                    {
                        byte[] code = {2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
                        key?.SetValue(name + ".lnk", code);
                    }
                }
            else
                using (var key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(PathExplorerStartupApproved + @"\StartupFolder", true))
                {
                    if (activate)
                    {
                        byte[] code = {3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
                        key?.SetValue(name + ".lnk", code);
                    }
                    else
                    {
                        byte[] code = {2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
                        key?.SetValue(name + ".lnk", code);
                    }
                }

            if (activate == TryFindActivate(name))
                throw new Exception("Ошибка изменения состояния автозагрузки, возможно, неактивная запись в реестре");
        }
    }
}