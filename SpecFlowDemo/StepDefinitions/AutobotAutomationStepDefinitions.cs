using OpenQA.Selenium;
using SpecFlowDemo.DataModels;
using SpecFlowDemo.Drivers;
using System;
using System.Xml.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TechTalk.SpecFlow.UnitTestProvider;

namespace SpecFlowDemo.StepDefinitions
{
    [Binding]
    public class AutobotAutomationStepDefinitions
    {

        private IUnitTestRuntimeProvider _runtimeProvider;

        public AutobotAutomationStepDefinitions(IUnitTestRuntimeProvider runtimeProvider)
        {
            _runtimeProvider = runtimeProvider;
        }

        [Given(@"i navigate to autobot website")]
        public void GivenINavigateToAutobotWebsite()
        {
            DriverManager.Driver.Url = "https://auto-bot-demo.vercel.app";
		}

		[When(@"i enter the name as ""([^""]*)""")]
        public void WhenIEnterTheNameAs(string name)
        {
            //_runtimeProvider.TestIgnore("Enter name is skipped");
			DriverManager.Driver.FindElement(By.Id("name")).SendKeys(name);

		}

        [When(@"i enter the age as (.*)")]
        public void WhenIEnterTheAgeAs(int age)
        {
			DriverManager.Driver.FindElement(By.Id("age")).SendKeys(age.ToString());
		}

		[When(@"i enter the email as ""([^""]*)""")]
        public void WhenIEnterTheEmailAs(string email)
        {
			DriverManager.Driver.FindElement(By.Id("email")).SendKeys(email);
		}

		[Then(@"i validate the values")]
        public void ThenIValidateTheValues()
        {
            throw new PendingStepException();
        }

		[When(@"i fill the user form")]
		public void WhenIFillTheUserForm(Table userTable)
		{
            //         userTable.Rows[0].TryGetValue("Name", out var name);
            //         userTable.Rows[0].TryGetValue("Age", out var age);
            //         userTable.Rows[0].TryGetValue("Email", out var email);
            //DriverManager.Driver.FindElement(By.Id("name")).SendKeys(name);
            //DriverManager.Driver.FindElement(By.Id("age")).SendKeys(age);
            //DriverManager.Driver.FindElement(By.Id("email")).SendKeys(email);
            UserData userData = userTable.CreateInstance<UserData>();

            DriverManager.Driver.FindElement(By.Id("name")).SendKeys(userData.Name);
            DriverManager.Driver.FindElement(By.Id("age")).SendKeys(userData.Age.ToString());
            DriverManager.Driver.FindElement(By.Id("email")).SendKeys(userData.Email);

        }



	}
}
