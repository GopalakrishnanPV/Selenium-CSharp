using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Data;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;

namespace _05_data_driven_framework
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IWebDriver driver = new ChromeDriver();
			driver.Manage().Window.Maximize();
			driver.Url = "https://auto-bot-demo.vercel.app/";
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);


			//var name = ExcelDataAccess.ReadCellValue("Data\\HomepageData.xlsx", "A2");
			//var age = ExcelDataAccess.ReadCellValue("Data\\HomepageData.xlsx", "B2");
			//var email = ExcelDataAccess.ReadCellValue("Data\\HomepageData.xlsx", "C2");

			HomePage homePage = new HomePage(driver);


			var dataSet = ExcelDataAccess.ReadExcelAsDataTable("Data\\HomepageData.xlsx");

			foreach (DataRow row in dataSet.Tables["Sheet1"].Rows)
			{
				homePage.EnterName(row["Name"].ToString());
				homePage.EnterAge(int.Parse(row["Age"].ToString()));
				homePage.EnterEmail(row["Email"].ToString());

			}

		}
	}
}