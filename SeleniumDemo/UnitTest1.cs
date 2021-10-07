using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Threading;

namespace SeleniumDemo
{
    public class UnitTest1
    {
        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public void Test1()
        {
            ////browser driver
            //IWebDriver webDriver = new ChromeDriver(@"C:\driver");
            //webDriver.Manage().Window.Maximize();
            //webDriver.Navigate().GoToUrl("https://www.trendyol.com/");

            
            //IWebElement popupCloseBtn = webDriver.FindElement(By.ClassName("modal-close"));
            //Assert.That(popupCloseBtn.Displayed, Is.True);
            //popupCloseBtn.Click();


            //IWebElement loginPageBtn = webDriver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[3]/div[1]/div[1]/div[1]/div[1]"));
            //loginPageBtn.Click();


            //var txtUserName = webDriver.FindElement(By.XPath("/html[1]/body[1]/div[3]/div[1]/div[3]/div[1]/form[1]/div[1]/input[1]"));
            //Assert.That(txtUserName.Displayed, Is.True);
            //txtUserName.SendKeys("beraat.koyuncu@yandex.com");

            //var txtPassword = webDriver.FindElement(By.XPath("/html[1]/body[1]/div[3]/div[1]/div[3]/div[1]/form[1]/div[2]/div[1]/div[1]/input[1]"));
            //Assert.That(txtPassword.Displayed, Is.True);
            //txtPassword.SendKeys("beraat123");


            //IWebElement loginBtn = webDriver.FindElement(By.XPath("/html[1]/body[1]/div[3]/div[1]/div[3]/div[1]/form[1]/button[1]"));
            //loginBtn.Click();
            //Thread.Sleep(2000);

            //IWebElement txtSearchBox = webDriver.FindElement(By.ClassName("search-box"));
            //Assert.That(txtSearchBox.Displayed, Is.True);
            //txtSearchBox.SendKeys("samsung a51");
            //txtSearchBox.SendKeys(Keys.Enter);

            //Thread.Sleep(2000);
            //IWebElement selectFilter = webDriver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[2]/select[1]/option[5]"));
            //selectFilter.Click();


            //Thread.Sleep(2000);
            //IWebElement fiyat = webDriver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[1]/div[1]/div[1]/div[2]/div[3]/div[1]/div[1]/div[1]/a[1]/div[2]/div[3]/div[1]/div[1]/div[3]/div[2]"));



            //FileStream fs = new FileStream(@"C:\Users\Beraat\Desktop\deneme.txt", FileMode.Append, FileAccess.Write);
            //StreamWriter sw = new StreamWriter(fs);
            //sw.WriteLine(fiyat.Text);
            //sw.Flush();
            //sw.Close();
            //fs.Close();




            ////IWebElement searchBtn = webDriver.FindElement(By.ClassName("search-icon"));
            ////searchBtn.Click();


            ////webDriver.Quit();



        }
    }
}