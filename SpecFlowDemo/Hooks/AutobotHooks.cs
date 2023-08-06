using SpecFlowDemo.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowDemo.Hooks
{
	[Binding]
	public class AutobotHooks
	{
		[BeforeScenario("chrome")]
		public void SetupChromeBrowser()
		{
			DriverManager.LaunchBrowser("chrome");
		}

		[BeforeScenario("edge")]
		public void SetupEdgeBrowser()
		{
			DriverManager.LaunchBrowser("edge");
		}

		[AfterScenario]
		public void QuitBrowser()
		{
			//DriverManager.QuitBrowser();
		}
	}
}
