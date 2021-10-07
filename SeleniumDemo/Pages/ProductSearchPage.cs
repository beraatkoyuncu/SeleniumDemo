using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SeleniumDemo.Pages
{
    public class ProductSearchPage
    {
        //private string kelime = "En çok değerlendirilenler";

        public ProductSearchPage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        public IWebDriver Driver { get; }

        public IWebElement txtSearchBox => Driver.FindElement(By.ClassName("search-box"));


        public void Search(string product)
        {
            txtSearchBox.SendKeys(product);
            txtSearchBox.SendKeys(Keys.Enter);
        }

    }
}
