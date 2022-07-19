using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
namespace LOLHelper.Common
{
    internal class ThreadUtil
    {
        /// <summary>
        /// 判断进程是否存在
        /// </summary>
        /// <param name="name">进程名</param>
        /// <returns>是否存在</returns>
        public static bool ExistProcesses(string name) 
        {
            return Process.GetProcessesByName(name).Length > 0;
        }

        /// <summary>
        /// 获取指定进程的命令行信息
        /// </summary>
        /// <param name="processName">进程名</param>
        /// <returns></returns>
        public static string GetCommandLines(string processName)
        {
            string wmiQuery = $"select CommandLine,ProcessId from Win32_Process where Name='{processName}.exe'";
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(wmiQuery))
            {
                using (ManagementObjectCollection retObjectCollection = searcher.Get())
                {
                    foreach (ManagementObject retObject in retObjectCollection)
                    {
                        return (string)retObject["CommandLine"];
                    }
                }
            }
            return "";
        }
    }
}
