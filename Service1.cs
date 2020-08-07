using System.ServiceProcess;

namespace clear_cache
{
    partial class ClearCache : ServiceBase
    {
        public ClearCache()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            LaunchScript.Ps();
        }

        protected override void OnStop()
        {
            // TODO: Add code here to perform any tear-down necessary to stop your service.
        }
    }
}
