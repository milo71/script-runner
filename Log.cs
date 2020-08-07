using System;
using System.IO;

namespace clear_cache
{
    class Log
    {
        public void Output()
        {
            string logdata = "Stuff";
            string logdate = (DateTime.Now).ToString(("d"));
            //Console.WriteLine("{0},{1}", logdate, logdata);
            //Console.ReadLine();

            string filepath = @"c:\service\logs\clear-cache.log";
            using (StreamWriter outputFile = new StreamWriter(filepath, true))
            {
                outputFile.WriteLine("{0},{1}", logdate, logdata);
            }
        }
    }
}
