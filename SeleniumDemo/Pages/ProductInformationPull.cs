using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Threading;

namespace SeleniumDemo.Pages
{
    public class ProductInformationPull
    {
        public ProductInformationPull(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        public IWebDriver Driver { get; }
        
        public void ExcelCreate(string txtSearch,string option)
        {
            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            for (int i = 1; i <= 5; i++)
            {
                IWebElement productTitle = Driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[1]/div[1]/div[1]/div[2]/div[3]/div[1]/div[" + i + "]/div[1]/a[1]/div[2]/div[1]/div[1]"));
                xlWorkSheet.Cells[i, 1] = productTitle.Text;
                Thread.Sleep(2000);

                IWebElement productPrice = Driver.FindElement(By.CssSelector("div.search-app-container div.srch-rslt-cntnt div.srch-prdcts-cntnr div.prdct-cntnr-wrppr div.p-card-wrppr.add-to-bs-card:nth-child(" + i + ") div.p-card-chldrn-cntnr a:nth-child(1) div.prdct-desc-cntnr-wrppr.with-basket-button > div.product-price"));
                xlWorkSheet.Cells[i, 2] = productPrice.Text;
                Thread.Sleep(2000);

                IWebElement productA = Driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[1]/div[1]/div[1]/div[2]/div[3]/div[1]/div[" + i + "]/div[1]/a[1]"));
                string productLink = productA.GetAttribute("href");
                xlWorkSheet.Cells[i, 3] = productLink;
                Thread.Sleep(2000);
            }

            xlWorkBook.SaveAs(@"C:\Projeler\SeleniumDemo\Excel\" + txtSearch + "_"+option+".xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);
        }


        
    }
}
