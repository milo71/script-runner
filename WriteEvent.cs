using System;
using System.Diagnostics;

namespace script_runner
{
    class Logging
    {
        public static void WriteEventLogEntry(string message)
        { 
            EventLog eventLog = new EventLog();
            
            if (!EventLog.SourceExists("ScriptRunner"))
            {
                EventLog.CreateEventSource("ScriptRunner", "Application");
            }

            eventLog.Source = "ScriptRunner";
            int eventID = 8;
            eventLog.WriteEntry(message,
                        EventLogEntryType.Information,
                        eventID);
            eventLog.Close();
        }
    }
}