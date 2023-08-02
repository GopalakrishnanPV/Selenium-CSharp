using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_data_driven_framework
{
	internal class ExcelDataAccess
	{
		public static string ReadCellValue(string filePath, string cellAddress)
		{
			using (var wbook = new XLWorkbook(filePath))
			{
				var wsheet = wbook.Worksheet(1);
				var data = wsheet.Cell(cellAddress).GetValue<string>();
				return data;
			}
		}

		public static DataSet ReadExcelAsDataTable(string filePath)
		{
			DataSet dataSet = new DataSet();
			using(var wbook = new XLWorkbook(filePath))
			{
				//var wsheet = wbook.Worksheet(1);
				foreach(IXLWorksheet wsheet in wbook.Worksheets)
				{
					DataTable dt = new DataTable(wsheet.Name);

					// Headers
					wsheet.FirstRowUsed().CellsUsed().ToList()
						.ForEach(x => { dt.Columns.Add(x.Value.ToString()); });

					// Values
					foreach (IXLRow row in wsheet.RowsUsed().Skip(1))
					{
						DataRow dataRow = dt.NewRow();
						for (int i = 0; i < dt.Columns.Count; i++)
						{
							dataRow[i] = row.Cell(i + 1).Value.ToString();
						}
						dt.Rows.Add(dataRow);

					}
					dataSet.Tables.Add(dt);
				}
			
			}

			return dataSet;
		}
	}
}
