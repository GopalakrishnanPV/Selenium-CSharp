using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowDemo.Drivers
{
	public class DriverManager
	{

		private static IWebDriver _driver;

		public static IWebDriver Driver
		{
			get { return _driver; }
			set { _driver = value; }
		}


		public static void LaunchBrowser(string browserName)
		{
			if (Driver == null)
			{
				if (browserName.Equals("edge", StringComparison.OrdinalIgnoreCase))
				{
					Driver = new EdgeDriver();
				}
				else
				{
					Driver = new ChromeDriver();
				}

				Driver.Manage().Window.Maximize();
				Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
			}
		}

		public static void QuitBrowser()
		{
			Driver.Quit();
		}

		//public static IWebDriver GetBrowser()
		//{
		//	return driver;
		//}

	}
}
