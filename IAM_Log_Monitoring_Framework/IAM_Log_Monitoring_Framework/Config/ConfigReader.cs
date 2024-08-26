using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAM_Log_Monitoring_Framework.Config
{
    public class ConfigReader
    {
        public static void SetFrameworkDetails()
        {
            var config = ReadTestVariables<dynamic>("Config\\GeneralConfig.json");

            Settings.Environment = config.Environment;
            Settings.Browser = config.Browser;

            if (((string)config.Environment).ToLower() == "dev")
            {
                Settings.URL = config.dev.URL;
            }
            else if (((string)config.Environment).ToLower() == "beta")      
            {
               
            }
            else if (((string)config.Environment).ToLower() == "production")
            { }
              
        }


        
        public static T ReadTestVariables<T>(string filePath)
        {
            var fileText = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<T>(fileText);
        }
    }
}
