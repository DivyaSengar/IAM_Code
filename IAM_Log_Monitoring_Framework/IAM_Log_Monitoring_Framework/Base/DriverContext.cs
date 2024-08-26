using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAM_Log_Monitoring_Framework.Base
{
   public class DriverContext
    {

        public static IWebDriver Driver { get; set; }
        public static Browser Browser { get; set; }
    }
}
