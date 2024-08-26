using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAM_Log_Monitoring_Framework.Helpers
{
    public class DisposeDriverService
    {
        private static readonly List<string> _processesToCheck =
           new List<string>
            {
                "chromedriver",
                "geckodriver"
           };

        public void CloseWebDriver(IWebDriver driver)
        {
            driver?.Dispose();

            var processes = Process.GetProcesses();
            foreach (var process in processes)
            {
                try
                {
                    var shouldKill = false;

                    foreach (var processName in _processesToCheck)
                    {
                        if (process.ProcessName.ToLower().Contains(processName))
                        {
                            shouldKill = true;
                            break;
                        }
                    }

                    if (shouldKill)
                    {
                        process.Kill();
                    }
                }
                catch (Exception) { }
            }
        }
    }
}
