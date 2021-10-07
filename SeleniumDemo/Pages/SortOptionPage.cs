using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumDemo.Pages
{
    public class SortOptionPage
    {
        public SortOptionPage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        public IWebDriver Driver { get; }


        public void ClickSort(string option)
        {
            IWebElement selectSort = Driver.FindElement(By.XPath("//option[contains(text(),'" + option + "')]"));
            selectSort.Click();
        }

    }


}