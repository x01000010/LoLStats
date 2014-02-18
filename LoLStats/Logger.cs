using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLStats
{
    class Logger
    {
        private static readonly string _file_name = string.Format(@"{0}/LoLStats/log.txt", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));

        static Logger()
        {
        }

        public static void log(string msg)
        {
            logTime(msg + Environment.NewLine);
        }

        static object _file_write_lock = new object();

        private static void logTime(string msg)
        {
            System.Diagnostics.Trace.Write("*" + msg);

            lock (_file_write_lock)
            {
                File.AppendText(DateTime.Now.ToString() + msg);
            }
        }
    }
}
