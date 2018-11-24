using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone
{
    public class Logger
    {
        /// <summary>
        /// Log reader outputs a time stamped log file
        /// </summary>
        public static void Log(SubMenu sub)
        {   
            // writes to the file log.txt
            using (StreamWriter sw = new StreamWriter("Log.txt", true))
            {
                sw.WriteLine($" {DateTime.Now} {sub.Action} ${sub.MoneyChange} ${sub.DisplayBalance}  ");
            }
        }
    }
}
