using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace _05_data_driven_framework
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IWebDriver driver = new ChromeDriver();
			driver.Manage().Window.Maximize();
			driver.Url = "https://www.auto-bot-demo.vercel.app";
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

			HomePage homePage = new HomePage(driver);
			homePage.EnterName("Gopal");
			homePage.EnterAge(18);
			homePage.EnterEmail("gopal@test.com");
		}
	}
}