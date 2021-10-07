using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumDemo.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SeleniumDemo.Tests
{
    public class Test1
    {
        IWebDriver webDriver = new ChromeDriver(@"C:\driver");

        [SetUp]
        public void Setup()
        {
            webDriver.Manage().Window.Maximize();

            webDriver.Navigate().GoToUrl("https://www.trendyol.com/");
        }

        [Test]
        public void Test()
        {
            string txtSearch = "samsung a51";
            string[] options = { "En Düşük Fiyat", "En Favoriler" };


            HomePage homePage = new HomePage(webDriver);
            homePage.ClickPopUpClose();
            homePage.ClickLoginPage();

            LoginPage loginPage = new LoginPage(webDriver);
            loginPage.Login("beraat.koyuncu@yandex.com", "beraat123");

            ProductSearchPage productSearchPage = new ProductSearchPage(webDriver);
            productSearchPage.Search(txtSearch);
            Thread.Sleep(4000);

            SortOptionPage sortOptionPage = new SortOptionPage(webDriver);
            ProductInformationPull productInformationPull = new ProductInformationPull(webDriver);
            foreach (string option in options) 
            {
                sortOptionPage.ClickSort(option);
                Thread.Sleep(4000);
                productInformationPull.ExcelCreate(txtSearch,option);
                Thread.Sleep(4000);
            }

        }

        [TearDown]
        public void TearDown() => webDriver.Quit();

    }
}
