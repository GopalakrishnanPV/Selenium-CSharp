using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading.Tasks;

namespace SpecFlowProject12.StepDefinitions
{
	[Binding]
	public sealed class FeaturesStepsDefinitions
	{
		private IWebDriver driver;
		[Given(@"Open the browser")]
		public void GivenOpenTheBrowser()
		{
			driver = new ChromeDriver();
		}
		[When(@"Enter the URL")]
		public void WhenEnterTheURL()
		{
			driver.Url = "https://www.youtube.com/";
		}

		[Then(@"Search for TestersTalk")]
		public void ThenSearchForTestersTalk()
		{
			driver.FindElement(By.XPath("//*[@name = 'search_query']")).SendKeys("Testers Talk");
		}
	}
}