using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumDemo.Pages
{
    public class HomePage
    {

        public HomePage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        public IWebDriver Driver { get; }

        public IWebElement popupCloseBtn => Driver.FindElement(By.ClassName("modal-close"));

        public void ClickPopUpClose() => popupCloseBtn.Click();

        public IWebElement btnLoginPage => Driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[3]/div[1]/div[1]/div[1]/div[1]"));

        public void ClickLoginPage() => btnLoginPage.Click();
    }
}
