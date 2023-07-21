using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using log4net;
using OpenQA.Selenium.Chrome;

namespace reporting_and_logging
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// // Logging with log4net
			//ILog log = LogManager.GetLogger(typeof(Program));
			//log.Debug("This is log4net debug");
			//log.Info("This is log4net info");
			//log.Error("This is log4net error");

			// Reporting
			ExtentReports extentReports = new ExtentReports();
			ExtentHtmlReporter extentHtmlReporter = new ExtentHtmlReporter("D://reports//index.html");
			extentReports.AttachReporter(extentHtmlReporter);
			ExtentTest loginTest = extentReports.CreateTest("Login Test");

			try
			{
				ChromeDriver driver = new ChromeDriver();
				loginTest.Log(Status.Pass, "Launch chrome driver successful");
				driver.Manage().Window.Maximize();
				loginTest.Log(Status.Pass, "Browser maximized");
				driver.Url = "https://auto-bot-demo.vercel.app";
				loginTest.Log(Status.Pass, "Navigated to practice website");
				// Simulation of an error.
				throw new Exception("Could not close browser");
				driver.Close();
				loginTest.Log(Status.Pass, "Driver closed");
			}
			catch (Exception ex)
			{
				loginTest.Log(Status.Fail, "Scenario failed with an exception: " + ex.Message);
			}
			finally
			{
				extentReports.Flush();
			}


			

		}
	}
}