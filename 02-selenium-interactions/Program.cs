using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Collections.ObjectModel;

namespace selenium_interactions
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IWebDriver driver = new ChromeDriver();
			// Waits for page load
			driver.Url = "https://auto-bot-demo.vercel.app/";

			////driver.Navigate().GoToUrl("https://auto-bot-demo.vercel.app/"); // Doesn't wait for page load
			////driver.Close(); // Close current tab
			////driver.Quit(); // Close whole browser window
			driver.Manage().Window.Maximize();

			// Implicit wait
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

			////// Explicit wait
			////WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
			////wait.Until(ExpectedConditions.ElementIsVisible(By.Id("Name")));

			////// Fluent wait
			////DefaultWait<IWebDriver> defaultWait = new DefaultWait<IWebDriver>(driver);
			////defaultWait.PollingInterval = TimeSpan.FromSeconds(5);
			////defaultWait.Timeout = TimeSpan.FromSeconds(50);
			////defaultWait.Until(ExpectedConditions.ElementIsVisible(By.Id("Name")));

			//// Textboxes
			//IWebElement name = driver.FindElement(By.Id("name"));
			//name.SendKeys("Prasad");
			//driver.FindElement(By.Id("age")).SendKeys("26");
			//driver.FindElement(By.Id("email")).SendKeys("prasad@gmail.com");
			//driver.FindElement(By.Id("password")).SendKeys("test@123");

			//// Dropdown
			//IWebElement dropdown = driver.FindElement(By.Id("dropdown"));
			//SelectElement selectElement = new SelectElement(dropdown);
			//selectElement.SelectByIndex(2);

			//// Date
			//IWebElement date = driver.FindElement(By.Id("date"));
			//date.SendKeys("06/28/2023");

			//// Time
			//IWebElement time = driver.FindElement(By.Id("time"));
			//time.SendKeys("08:30PM");

			//// Range
			//IWebElement range = driver.FindElement(By.Id("range-slider"));

			//// Applicable for every field
			//int rangeValue = int.Parse(range.GetAttribute("value"));

			//for (int i = 0; i < rangeValue; i++)
			//{
			//	range.SendKeys(Keys.Left);
			//}

			//for (int i = 1; i < 10; i++)
			//{
			//	range.SendKeys(Keys.Right);
			//}

			////// Checkboxes
			//IWebElement checkbox = driver.FindElement(By.Id("tamil"));
			//checkbox.Click();

			//ReadOnlyCollection<IWebElement> checkboxes = driver.FindElements(By.Name("language"));

			//foreach (IWebElement item in checkboxes)
			//{
			//	if (item.Selected)
			//	{
			//		item.Click();
			//	}
			//}

			//// Radio button
			//ReadOnlyCollection<IWebElement> radiobuttons = driver.FindElements(By.Name("gender"));
			//foreach (IWebElement item in radiobuttons)
			//{
			//	if (item.GetAttribute("value") == "female")
			//	{
			//		item.Click();
			//		break;
			//	}
			//}

			//// Right click
			//IWebElement clickElement = driver.FindElement(By.Id("click"));
			//Actions actions = new Actions(driver);
			//actions.ContextClick(clickElement);

			//// Alert
			//IWebElement alertElement = driver.FindElement(By.Id("alert"));
			//IAlert alert = driver.SwitchTo().Alert();
			//alert.Accept();

			//// New Tab and Window
			////Find current window handle
			//string currentTabHandle = driver.CurrentWindowHandle;
			//// Click on the new tab button
			//driver.FindElement(By.Id("new_window")).Click();
			//// // Find all handles
			//IEnumerable<string> tabHandles = driver.WindowHandles;
			//// Find a handle which does not match the current handle
			//string newTabHandle = tabHandles.First(x => x != currentTabHandle);
			//// Switching to the new tab
			//driver.SwitchTo().Window(newTabHandle);

			//IWebElement linkedIn = driver.FindElement(By.XPath("//button[text()='Linked In']//parent::a"));
			//linkedIn.Click();

			//// IFrames
			//// Click on the new tab button
			//IWebElement iframe = driver.FindElement(By.TagName("iframe"));
			//driver.ExecuteJavaScript("arguments[0].scrollIntoView({block:'center'});", iframe);

			//// Switching to the new tab
			//driver.SwitchTo().Frame(iframe);

			//IWebElement linkedIn2 = driver.FindElement(By.XPath("//button[text()='Linked In']//parent::a"));
			//driver.ExecuteJavaScript("arguments[0].scrollIntoView({block:'center'});", linkedIn2);
			//linkedIn2.Click();
		}
	}
}