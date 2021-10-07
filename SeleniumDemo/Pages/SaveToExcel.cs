using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace SeleniumDemo.Pages
{
    public class SaveToExcel
    {

		public void ExcelCreate()
        {
			Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
			Excel.Workbook xlWorkBook;
			Excel.Worksheet xlWorkSheet;
			object misValue = System.Reflection.Missing.Value;

			xlWorkBook = xlApp.Workbooks.Add(misValue);
			xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

			for (int i = 1; i <= 10; i++)
            {
				xlWorkSheet.Cells[i, 1] = "Product Title";
				xlWorkSheet.Cells[i, 2] = "İsim";
				xlWorkSheet.Cells[i, 3] = "Sıra NO";
				xlWorkSheet.Cells[i, 4] = "İsim";
			}

			

			xlWorkBook.SaveAs(@"C:\Users\Beraat\Desktop\deneme-dosya.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
			xlWorkBook.Close(true, misValue, misValue);
			xlApp.Quit();

			Marshal.ReleaseComObject(xlWorkSheet);
			Marshal.ReleaseComObject(xlWorkBook);
			Marshal.ReleaseComObject(xlApp);
		}

			
    }
}
