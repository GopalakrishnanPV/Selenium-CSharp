using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_data_driven_framework
{
	public class HomePage
	{
		IWebDriver _driver;

		[FindsBy(How = How.Id, Using = "name")]
		private IWebElement nameTextBox;

		[FindsBy(How = How.Id, Using = "age")]
		private IWebElement ageTextBox;

		[FindsBy(How = How.Id, Using = "email")]
		private IWebElement emailTextBox;

		public HomePage(IWebDriver driver)
		{
			_driver = driver;
			PageFactory.InitElements(_driver, this);
		}

		public void EnterName(string name)
		{
			nameTextBox.Clear();
			nameTextBox.SendKeys(name);
		}

		public void EnterAge(int age)
		{
			ageTextBox.Clear();
			ageTextBox.SendKeys($"{age}");
		}

		public void EnterEmail(string email)
		{
			emailTextBox.Clear();
			emailTextBox.SendKeys(email);
		}
	}
}


