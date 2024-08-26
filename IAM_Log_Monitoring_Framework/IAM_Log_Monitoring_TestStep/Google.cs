using IAM_Log_Monitoring_Framework.Base;
using IAM_Log_Monitoring_Framework.Config;
using IAM_Log_Monitoring_Framework.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace IAM_Log_Monitoring_TestStep
{
    [TestClass]
    public class Google
    {
        DisposeDriverService DisposeDriver;

		[AssemblyInitialize]
		public static void MyTestInitialize(TestContext TestContext)
		{
			ConfigReader.SetFrameworkDetails();
			
		}

		[TestInitialize]
		public void TestInitialize()
		{
			DisposeDriver = new DisposeDriverService();
			
			DisposeDriver.CloseWebDriver(DriverContext.Driver);
      		TestInitializeHook.InitializeSettings();
	
		}
		[TestCleanup]
		public void Cleanup()
		{
			try
			{
				
				//DisposeDriver.CloseWebDriver(DriverContext.Driver);
			}
			catch (Exception e)
			{
				
			}
		}

		[AssemblyCleanup]
		public static void TearDown()
		{
		}
		[TestMethod]
        public void TestMethod()
        {
			TestInitializeHook.NavigateToSite(Settings.URL);
		
		}
    }
}
