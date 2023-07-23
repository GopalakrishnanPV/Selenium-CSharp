using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_data_driven_framework
{
	internal class ExcelDataAccess
	{
		public static string TestDataFileConnection()
		{
			var fileName = ConfigurationManager.AppSettings["TestDataSheetPath"];
			var con = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = {0}; Extended Properties=Excel 12.0;", fileName);
			return con;
		}

		public static HomepageData? GetTestData(string keyName)
		{
			//using (var connection = new OleDbConnection(TestDataFileConnection()))
			//{
			//	connection.Open();
			//	var query = string.Format("select * from [DataSet$] where key='{0}'", keyName);
			//	var value = connection.Query<HomepageData>(query).FirstOrDefault();
			//	connection.Close();
			//	return value;
			//}
			return null;
		}
	}
}
