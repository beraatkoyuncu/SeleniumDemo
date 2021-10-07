using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SeleniumDemo.Pages
{
    public class LoginPage
    {
        public LoginPage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        public IWebDriver Driver { get; }

        public IWebElement txtUserName => Driver.FindElement(By.XPath("/html[1]/body[1]/div[3]/div[1]/div[3]/div[1]/form[1]/div[1]/input[1]"));

        public IWebElement txtPassword => Driver.FindElement(By.XPath("/html[1]/body[1]/div[3]/div[1]/div[3]/div[1]/form[1]/div[2]/div[1]/div[1]/input[1]"));

        public IWebElement btnLogin => Driver.FindElement(By.XPath("/html[1]/body[1]/div[3]/div[1]/div[3]/div[1]/form[1]/button[1]"));
        
        public void Login(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
            btnLogin.Click();
        }
        
    }
}
