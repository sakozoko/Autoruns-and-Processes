using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Win32;

namespace Cleaner.Process
{
    public class ProcessNames
    {
        private const string PathRegistry = @"SOFTWARE\MyCleaner";
        private const string SubKeyName = "ProcessNames";
        public static IEnumerable<string> GetActivatedProcessNames()
        {
            return System.Diagnostics.Process.GetProcesses().Select(proc => proc.ProcessName).ToHashSet();
        }
        public static IEnumerable<string> GetSavedProcNames()
        {
            HashSet<string> str;
            using (var key = Registry.CurrentUser.CreateSubKey(PathRegistry))
            {
                str = (key?.GetValue(SubKeyName) as string[] ?? Array.Empty<string>()).ToHashSet();
            }
            return str;

        }

        public static void AddProcNames(HashSet<string> procNames)
        {
            HashSet<string> processSet = procNames;
            procNames = GetSavedProcNames()?.Except(procNames).Union(processSet).ToHashSet();

            SaveProcNames(procNames);
        }

        public static void SaveProcNames(HashSet<string> procNames)
        {
            using (var key = Registry.CurrentUser.CreateSubKey(PathRegistry))
            {
                key?.SetValue(SubKeyName, procNames.ToArray());
            }
        }
    }
}