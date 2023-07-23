using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace _04_page_object_model
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IWebDriver driver = new ChromeDriver();
			driver.Manage().Window.Maximize();
			driver.Url = "https://auto-bot-demo.vercel.app/";
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

			HomePage homePage = new HomePage(driver);
			homePage.EnterName("Gopal");
			homePage.EnterAge(18);
			homePage.EnterEmail("gopal@test.com");
		}
	}
}