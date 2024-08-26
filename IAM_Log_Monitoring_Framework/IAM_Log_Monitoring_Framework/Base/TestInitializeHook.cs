using IAM_Log_Monitoring_Framework.Config;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAM_Log_Monitoring_Framework.Base
{
    public class TestInitializeHook
    {
        public static void InitializeSettings()
        {
            OpenBrowser();
        }

        private static void OpenBrowser()
        {
            if (Settings.Browser.ToLower() == "chrome")
            {
                ChromeOptions option = new ChromeOptions();
                option.AddArguments("--start-maximized");
                ChromeDriver  chromeDriver = new ChromeDriver(option);
                chromeDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
                chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                DriverContext.Driver = chromeDriver;
                DriverContext.Driver.Manage().Timeouts().PageLoad.Add(TimeSpan.FromSeconds(120));
                DriverContext.Browser = new Browser(DriverContext.Driver);
            }
            else
            {
                throw new ArgumentOutOfRangeException("No Implmemnttion available to initialize drivers other then chrome");
            }

        }

        public static void NavigateToSite(string siteName)
        {
            DriverContext.Driver.Navigate().GoToUrl(siteName);
        }
    }
}
